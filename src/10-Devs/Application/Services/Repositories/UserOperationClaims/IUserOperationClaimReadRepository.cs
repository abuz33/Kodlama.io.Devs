//-------------------------------------------------------------------------------------------------
//
// IUserOperationClaimReadRepository.cs -- The IUserOperationClaimReadRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories.UserOperationClaims;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IUserOperationClaimReadRepository interface TODO: Describe class here
/// </summary>
public interface IUserOperationClaimReadRepository : IReadRepository<UserOperationClaim>
{

}
