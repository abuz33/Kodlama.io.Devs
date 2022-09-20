//-------------------------------------------------------------------------------------------------
//
// Framework.cs -- The Framework class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.Frameworks;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.Frameworks
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The FrameworkReadRepository class TODO: Describe class here
    /// </summary>
    public class FrameworkReadRepository : ReadRepository<Framework, KodlamaIODevsDbContext>, IFrameworkReadRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public FrameworkReadRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
