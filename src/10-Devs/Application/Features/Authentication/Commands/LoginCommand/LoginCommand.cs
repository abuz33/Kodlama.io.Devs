//-------------------------------------------------------------------------------------------------
//
// LoginCommand.cs -- The LoginCommand class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.Authentication.Dtos;
using Application.Features.Authentication.Rules;
using Application.Services.Repositories.RefreshTokens;
using Application.Services.Repositories.Users;
using AutoMapper;
using Core.Security.Dtos;
using Core.Security.JWT;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Application.Features.Authentication.Commands.LoginCommand;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The LoginCommand class
/// </summary>
public class LoginCommand : UserForLoginDto, IRequest<TokenDto>
{
    //-----------------------------------------------------------------------------------------
    /// <summary>
    /// The LoginCommandHandler class
    /// </summary>
    public class LoginCommandHandler : UserForLoginDto, IRequestHandler<LoginCommand, TokenDto>
    {
        private readonly IMapper _mapper;
        private readonly ITokenHelper _tokenHelper;
        private readonly IUserReadRepository _userReadRepository;
        private readonly IRefreshTokenWriteRepository _refreshTokenWriteRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly AuthenticationBusinessRules _authenticationBusinessRules;

        //-----------------------------------------------------------------------------------------
        /// <summary>
        /// constructor
        /// </summary>
        /// <param name="mapper">Mapper</param>
        public LoginCommandHandler (IUserReadRepository userReadRepository, IMapper mapper, ITokenHelper tokenHelper,
            AuthenticationBusinessRules authenticationBusinessRules, IHttpContextAccessor httpContextAccessor, IRefreshTokenWriteRepository refreshTokenWriteRepository)
        {
            _mapper = mapper;
            _tokenHelper = tokenHelper;
            _userReadRepository = userReadRepository;
            _httpContextAccessor = httpContextAccessor;
            _refreshTokenWriteRepository = refreshTokenWriteRepository;
            _authenticationBusinessRules = authenticationBusinessRules;
        }

        //-----------------------------------------------------------------------------------------
        /// <inheritdoc />
        public Task<TokenDto> Handle (LoginCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
