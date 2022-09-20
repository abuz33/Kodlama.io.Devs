//-------------------------------------------------------------------------------------------------
//
// UserOperationClaimWriteRepository.cs -- The UserOperationClaimWriteRepository class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.UserOperationClaims;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.UserOperationClaims
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The UserOperationClaimWriteRepository class TODO: Describe class here
    /// </summary>
    public class UserOperationClaimWriteRepository : WriteRepository<UserOperationClaim, KodlamaIODevsDbContext>, IUserOperationClaimWriteRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public UserOperationClaimWriteRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
