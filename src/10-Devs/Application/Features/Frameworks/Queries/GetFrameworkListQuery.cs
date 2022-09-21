//-------------------------------------------------------------------------------------------------
//
// GetFrameworkListQuery.cs -- The GetFrameworkListQuery class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.Frameworks.Models;
using Application.Services.Repositories.Frameworks;
using AutoMapper;
using Core.Application.Requests;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.Frameworks.Queries
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The GetFrameworkListQuery class TODO: Describe class here
    /// </summary>
    public class GetFrameworkListQuery : IRequest<FrameworkListModel>
    {
        public PageRequest PageRequest { get; set; }

        public class GetListFrameworkQueryHandler : IRequestHandler<GetFrameworkListQuery, FrameworkListModel>
        {
            private readonly IFrameworkReadRepository _frameworkReadRepository;
            private readonly IMapper _mapper;

            public GetListFrameworkQueryHandler (IFrameworkReadRepository frameworkReadRepository, IMapper mapper)
            {
                _frameworkReadRepository = frameworkReadRepository;
                _mapper = mapper;
            }

            public async Task<FrameworkListModel> Handle (GetFrameworkListQuery request, CancellationToken cancellationToken)
            {
                var frameworks = await _frameworkReadRepository.GetListAsync(include: f => f.Include(f => f.ProgrammingLanguage),
                    index: request.PageRequest.Page, size: request.PageRequest.PageSize);
                return _mapper.Map<FrameworkListModel>(frameworks);
            }
        }
    }
}
