//-------------------------------------------------------------------------------------------------
//
// OperationClaim.cs -- The OperationClaim class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.OperationClaims;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.OperationClaims
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The OperationClaimReadRepository class TODO: Describe class here
    /// </summary>
    public class OperationClaimReadRepository : ReadRepository<OperationClaim, KodlamaIODevsDbContext>, IOperationClaimReadRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public OperationClaimReadRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
