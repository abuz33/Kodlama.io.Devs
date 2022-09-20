//-------------------------------------------------------------------------------------------------
//
// RefreshTokenLoginCommand.cs -- The RefreshTokenLoginCommand class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.Authentication.Dtos;
using Application.Features.Authentication.Rules;
using Application.Services.Repositories.RefreshTokens;
using Application.Services.Repositories.UserOperationClaims;
using Application.Services.Repositories.Users;
using AutoMapper;
using Core.Security.Entities;
using Core.Security.Extensions;
using Core.Security.JWT;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Authentication.Commands.LoginCommand;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The RefreshTokenLoginCommand class TODO: Describe class here
/// </summary>
public class RefreshTokenLoginCommand : IRequest<TokenDto>
{
    public string AccessToken { get; set; }
    public string RefreshToken { get; set; }

    //-----------------------------------------------------------------------------------------
    /// <summary>
    /// RefreshTokenLoginCommandHandler class TODO: Describe class here
    /// </summary>
    public class RefreshTokenLoginCommandHandler : IRequestHandler<RefreshTokenLoginCommand, TokenDto>
    {
        private readonly IMapper _mapper;
        private readonly ITokenHelper _tokenHelper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IRefreshTokenReadRepository _refreshTokenReadRepository;
        private readonly IRefreshTokenWriteRepository _refreshTokenWriteRepository;
        private readonly IUserOperationClaimReadRepository _userOperationClaimReadRepository;
        private readonly AuthenticationBusinessRules _authenticationBusinessRules;

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="mapper">Mapper</param>
        public RefreshTokenLoginCommandHandler (IUserReadRepository userReadRepository, ITokenHelper tokenHelper, IRefreshTokenReadRepository refreshTokenReadRepository,
            IUserOperationClaimReadRepository userOperationClaimReadRepository, IHttpContextAccessor httpContextAccessor, IRefreshTokenWriteRepository refreshTokenWriteRepository,
            IMapper mapper, AuthenticationBusinessRules authenticationBusinessRules)
        {
            _mapper = mapper;
            _authenticationBusinessRules = authenticationBusinessRules;
            _tokenHelper = tokenHelper;
            _httpContextAccessor = httpContextAccessor;
            _userReadRepository = userReadRepository;
            _refreshTokenReadRepository = refreshTokenReadRepository;
            _refreshTokenWriteRepository = refreshTokenWriteRepository;
            _userOperationClaimReadRepository = userOperationClaimReadRepository;
        }

        public IRefreshTokenWriteRepository RefreshTokenWriteRepository => _refreshTokenWriteRepository;

        //-----------------------------------------------------------------------------------------
        /// <inheritdoc />
        public async Task<TokenDto> Handle (RefreshTokenLoginCommand request, CancellationToken cancellationToken)
        {
            var clientIpAddress = _httpContextAccessor.HttpContext?.Connection.RemoteIpAddress?.ToString();
            var principal = _tokenHelper.GetPrincipalFromExpiredToken(request.AccessToken);
            var userId = principal.GetUserId();
            var refreshToken = await _refreshTokenReadRepository.GetAsync(r => r.UserId == Guid.Parse(userId) && r.Token == request.RefreshToken && r.Revoked == null);
            await _authenticationBusinessRules.CheckIfRefresfTokenIsValid(refreshToken);

            var user = await _userReadRepository.GetByIdAsync(userId);
            var operationClaims = (await _userOperationClaimReadRepository.GetListAsync(u => u.UserId == Guid.Parse(userId),
                include: m => m.Include(o => o.OperationClaim))).Items.Select(u => u.OperationClaim).ToList();
            var newAccessToken = _tokenHelper.CreateToken(user, operationClaims);
            var newRefreshToken = _tokenHelper.CreateRefreshToken(user, clientIpAddress);
            refreshToken.Revoked = DateTime.UtcNow;
            refreshToken.RevokedByIp = clientIpAddress;
            refreshToken.ReplacedByToken = newRefreshToken.Token;
            await RefreshTokenWriteRepository.Update(refreshToken);
            await RefreshTokenWriteRepository.AddAsync(newRefreshToken);
            return new TokenDto
            {
                AccessToken = newAccessToken,
                RefreshToken = _mapper.Map<RefreshToken, RefreshTokenDto>(newRefreshToken)
            };
        }
    }
}
