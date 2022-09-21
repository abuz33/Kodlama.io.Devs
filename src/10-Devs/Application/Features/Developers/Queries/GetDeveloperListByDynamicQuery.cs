using Application.Features.Developers.Models;
using Application.Services.Repositories.Developers;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using Core.Security.Enums;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Developers.Queries;

public class GetDeveloperListByDynamicQuery : IRequest<DeveloperListModel>, ISecuredRequest
{
    public Dynamic Dynamic { get; set; }
    public PageRequest PageRequest { get; set; }

    public string[] Roles { get; } = { OperationClaimsEnum.Developer.ToString() };

    public class GetDeveloperListByDynamicQueryHandler : IRequestHandler<GetDeveloperListByDynamicQuery, DeveloperListModel>
    {
        private readonly IDeveloperReadRepository _developerReadRepository;
        private readonly IMapper _mapper;

        public GetDeveloperListByDynamicQueryHandler (IMapper mapper, IDeveloperReadRepository developerReadRepository)
        {
            _developerReadRepository = developerReadRepository;
            _mapper = mapper;
        }

        public async Task<DeveloperListModel> Handle (GetDeveloperListByDynamicQuery request, CancellationToken cancellationToken)
        {
            var models = await _developerReadRepository.GetListByDynamicAsync(request.Dynamic, include:
                m => m.Include(c => c.User),
                index: request.PageRequest.Page,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken);
            return _mapper.Map<DeveloperListModel>(models);
        }
    }
}
