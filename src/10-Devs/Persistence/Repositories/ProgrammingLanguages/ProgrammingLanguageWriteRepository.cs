//-------------------------------------------------------------------------------------------------
//
// ProgrammingLanguageWriteRepository.cs -- The ProgrammingLanguageWriteRepository class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.ProgrammingLanguages;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.ProgrammingLanguages
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The ProgrammingLanguageWriteRepository class TODO: Describe class here
    /// </summary>
    public class ProgrammingLanguageWriteRepository : WriteRepository<ProgrammingLanguage, KodlamaIODevsDbContext>, IProgrammingLanguageWriteRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public ProgrammingLanguageWriteRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
