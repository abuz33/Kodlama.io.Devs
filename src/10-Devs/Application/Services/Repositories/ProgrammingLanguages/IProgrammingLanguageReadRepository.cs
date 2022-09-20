//-------------------------------------------------------------------------------------------------
//
// IProgrammingLanguageReadRepository.cs -- The IProgrammingLanguageReadRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories.ProgrammingLanguages;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IProgrammingLanguageReadRepository interface TODO: Describe class here
/// </summary>
public interface IProgrammingLanguageReadRepository : IReadRepository<ProgrammingLanguage>
{
}
