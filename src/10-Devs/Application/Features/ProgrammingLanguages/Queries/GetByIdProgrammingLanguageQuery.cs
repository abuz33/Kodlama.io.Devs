using Application.Features.ProgrammingLanguages.Dtos.BaseDto;
using Application.Features.ProgrammingLanguages.Rules;
using Application.Services.Repositories.ProgrammingLanguages;
using AutoMapper;
using MediatR;

namespace Application.Features.ProgrammingLanguages.Queries;

public class GetProgrammingLanguageByIdQuery : IRequest<BaseProgrammingLanguageDto>
{
    public string Id { get; set; }

    public class GetProgrammingLanguageByIdQueryHandler : IRequestHandler<GetProgrammingLanguageByIdQuery, BaseProgrammingLanguageDto>
    {
        private readonly IProgrammingLanguageReadRepository _programmingLanguageReadRepository;
        private readonly ProgrammingLanguageBusinessRules _programmingLanguageBusinessRules;
        private readonly IMapper _mapper;

        public GetProgrammingLanguageByIdQueryHandler (IProgrammingLanguageReadRepository programmingLanguageReadRepository, IMapper mapper, ProgrammingLanguageBusinessRules programmingLanguageBusinessRules)
        {
            _programmingLanguageReadRepository = programmingLanguageReadRepository;
            _programmingLanguageBusinessRules = programmingLanguageBusinessRules;
            _mapper = mapper;
        }

        public async Task<BaseProgrammingLanguageDto> Handle (GetProgrammingLanguageByIdQuery request, CancellationToken cancellationToken)
        {
            var programmingLanguage = await _programmingLanguageReadRepository.GetByIdAsync(request.Id);
            await _programmingLanguageBusinessRules.CheckIfProgrammingLanguageDoesNotExists(programmingLanguage);

            return _mapper.Map<BaseProgrammingLanguageDto>(programmingLanguage);
        }
    }
}
