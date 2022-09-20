//-------------------------------------------------------------------------------------------------
//
// ProgrammingLanguage.cs -- The ProgrammingLanguage class.
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
    /// The ProgrammingLanguageReadRepository class TODO: Describe class here
    /// </summary>
    public class ProgrammingLanguageReadRepository : ReadRepository<ProgrammingLanguage, KodlamaIODevsDbContext>, IProgrammingLanguageReadRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public ProgrammingLanguageReadRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
