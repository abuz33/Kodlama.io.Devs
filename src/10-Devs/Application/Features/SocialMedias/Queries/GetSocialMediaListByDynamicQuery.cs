using Application.Features.SocialMedias.Models;
using Application.Services.Repositories.SocialMedias;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Core.Security.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.SocialMedias.Queries;

public class GetSocialMediaListByDynamicQuery : IRequest<SocialMediaListModel>, ISecuredRequest
{
    public Dynamic Dynamic { get; set; }
    public PageRequest PageRequest { get; set; }

    public string[] Roles { get; } = { OperationClaimsEnum.User.ToString() };

    public class GetSocialMediaListByDynamicQueryHandler : IRequestHandler<GetSocialMediaListByDynamicQuery, SocialMediaListModel>
    {
        private readonly ISocialMediaReadRepository _socialMediaReadRepository;
        private readonly IMapper _mapper;

        public GetSocialMediaListByDynamicQueryHandler (IMapper mapper, ISocialMediaReadRepository socialMediaReadRepository)
        {
            _socialMediaReadRepository = socialMediaReadRepository;
            _mapper = mapper;
        }

        public async Task<SocialMediaListModel> Handle (GetSocialMediaListByDynamicQuery request, CancellationToken cancellationToken)
        {
            var models = await _socialMediaReadRepository.GetListByDynamicAsync(request.Dynamic, include:
                m => m.Include(c => c.Developer),
                index: request.PageRequest.Page,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken);
            return _mapper.Map<SocialMediaListModel>(models);
        }
    }
}
