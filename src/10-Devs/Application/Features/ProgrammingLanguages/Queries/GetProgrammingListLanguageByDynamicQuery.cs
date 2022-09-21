using Application.Features.ProgrammingLanguages.Models;
using Application.Services.Repositories.ProgrammingLanguages;
using AutoMapper;
using Core.Application.Pipelines.Authorization;
using Core.Application.Requests;
using Core.Persistence.Dynamic;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.ProgrammingLanguages.Queries;

public class GetProgrammingListLanguageByDynamicQuery : IRequest<ProgrammingLanguageListModel>, ISecuredRequest
{
    public Dynamic Dynamic { get; set; }
    public PageRequest PageRequest { get; set; }

    public string[] Roles { get; } = { "User" };

    public class GetProgrammingListLanguageByDynamicQueryHandler : IRequestHandler<GetProgrammingListLanguageByDynamicQuery, ProgrammingLanguageListModel>
    {
        private readonly IProgrammingLanguageReadRepository _programmingLanguageReadRepository;
        private readonly IMapper _mapper;

        public GetProgrammingListLanguageByDynamicQueryHandler (IMapper mapper, IProgrammingLanguageReadRepository programmingLanguageReadRepository)
        {
            _programmingLanguageReadRepository = programmingLanguageReadRepository;
            _mapper = mapper;
        }

        public async Task<ProgrammingLanguageListModel> Handle (GetProgrammingListLanguageByDynamicQuery request, CancellationToken cancellationToken)
        {
            var models = await _programmingLanguageReadRepository.GetListByDynamicAsync(request.Dynamic, include:
                m => m.Include(c => c.Frameworks),
                index: request.PageRequest.Page,
                size: request.PageRequest.PageSize,
                cancellationToken: cancellationToken);
            return _mapper.Map<ProgrammingLanguageListModel>(models);
        }
    }
}
