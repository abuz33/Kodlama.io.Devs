//-------------------------------------------------------------------------------------------------
//
// DeveloperWriteRepository.cs -- The DeveloperWriteRepository class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.Developers;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.Developers
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The DeveloperWriteRepository class TODO: Describe class here
    /// </summary>
    public class DeveloperWriteRepository : WriteRepository<Developer, KodlamaIODevsDbContext>, IDeveloperWriteRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public DeveloperWriteRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
