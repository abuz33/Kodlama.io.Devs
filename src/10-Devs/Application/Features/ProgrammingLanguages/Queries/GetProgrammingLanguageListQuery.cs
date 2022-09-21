//-------------------------------------------------------------------------------------------------
//
// GetProgrammingLanguageListQuery.cs -- The GetProgrammingLanguageListQuery class.
//
//-------------------------------------------------------------------------------------------------

using Application.Features.ProgrammingLanguages.Models;
using Application.Services.Repositories.ProgrammingLanguages;
using AutoMapper;
using Core.Application.Requests;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.Features.ProgrammingLanguages.Queries;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The GetProgrammingLanguageListQuery class TODO: Describe class here
/// </summary>
public class GetProgrammingLanguageListQuery : IRequest<ProgrammingLanguageListModel>
{
    public PageRequest PageRequest { get; set; }

    public class GetListProgrammingLanguageQueryHandler : IRequestHandler<GetProgrammingLanguageListQuery, ProgrammingLanguageListModel>
    {
        private readonly IProgrammingLanguageReadRepository _programmingLanguageReadRepository;
        private readonly IMapper _mapper;

        public GetListProgrammingLanguageQueryHandler (IProgrammingLanguageReadRepository programmingLanguageReadRepository, IMapper mapper)
        {
            _programmingLanguageReadRepository = programmingLanguageReadRepository;
            _mapper = mapper;
        }

        public async Task<ProgrammingLanguageListModel> Handle (GetProgrammingLanguageListQuery request, CancellationToken cancellationToken)
        {
            var programmingLanguages = await _programmingLanguageReadRepository.GetListAsync(include: m => m.Include(p => p.Frameworks),
                index: request.PageRequest.Page, size: request.PageRequest.PageSize);
            return _mapper.Map<ProgrammingLanguageListModel>(programmingLanguages);
        }
    }
}
