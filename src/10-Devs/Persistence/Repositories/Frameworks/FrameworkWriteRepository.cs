//-------------------------------------------------------------------------------------------------
//
// FrameworkWriteRepository.cs -- The FrameworkWriteRepository class.
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
    /// The FrameworkWriteRepository class TODO: Describe class here
    /// </summary>
    public class FrameworkWriteRepository : WriteRepository<Framework, KodlamaIODevsDbContext>, IFrameworkWriteRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public FrameworkWriteRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
