//-------------------------------------------------------------------------------------------------
//
// Developer.cs -- The Developer class.
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
    /// The DeveloperReadRepository class TODO: Describe class here
    /// </summary>
    public class DeveloperReadRepository : ReadRepository<Developer, KodlamaIODevsDbContext>, IDeveloperReadRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public DeveloperReadRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
