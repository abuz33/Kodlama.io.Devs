//-------------------------------------------------------------------------------------------------
//
// UserOperationClaim.cs -- The UserOperationClaim class.
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
    /// The UserOperationClaimReadRepository class TODO: Describe class here
    /// </summary>
    public class UserOperationClaimReadRepository : ReadRepository<UserOperationClaim, KodlamaIODevsDbContext>, IUserOperationClaimReadRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public UserOperationClaimReadRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
