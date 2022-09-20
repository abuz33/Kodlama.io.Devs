//-------------------------------------------------------------------------------------------------
//
// OperationClaimWriteRepository.cs -- The OperationClaimWriteRepository class.
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
    /// The OperationClaimWriteRepository class TODO: Describe class here
    /// </summary>
    public class OperationClaimWriteRepository : WriteRepository<OperationClaim, KodlamaIODevsDbContext>, IOperationClaimWriteRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public OperationClaimWriteRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
