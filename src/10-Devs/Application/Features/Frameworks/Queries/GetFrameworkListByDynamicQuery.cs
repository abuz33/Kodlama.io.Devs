//-------------------------------------------------------------------------------------------------
//
// GetFrameworkListByDynamicQuery.cs -- The GetFrameworkListByDynamicQuery class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.Frameworks.Models;
using Application.Services.Repositories.Frameworks;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Frameworks.Queries;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The GetFrameworkListByDynamicQuery class TODO: Describe class here
/// </summary>
public class GetFrameworkListByDynamicQuery : IRequest<FrameworkListModel>, ISecuredRequest
{
    public Dynamic Dynamic { get; set; }
    public PageRequest PageRequest { get; set; }

    public string[] Roles { get; } = { "User" };

    public class GetFrameworkListByDynamicQueryHandler : IRequestHandler<GetFrameworkListByDynamicQuery, FrameworkListModel>
    {
        private readonly IFrameworkReadRepository _frameworkReadRepository;
        private readonly IMapper _mapper;

        public GetFrameworkListByDynamicQueryHandler(IMapper mapper, IFrameworkReadRepository frameworkReadRepository)
        {
            _frameworkReadRepository = frameworkReadRepository;
            _mapper = mapper;
        }

        public async Task<FrameworkListModel> Handle (GetFrameworkListByDynamicQuery request, CancellationToken cancellationToken)
        {
            var models = await _frameworkReadRepository.GetListByDynamicAsync(request.Dynamic, include:
                m => m.Include(c => c.ProgrammingLanguage),
                index: request.PageRequest.Page,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken);
            return _mapper.Map<FrameworkListModel>(models);
        }
    }
}
