//-------------------------------------------------------------------------------------------------
//
// IUserOperationClaimWriteRepository.cs -- The IUserOperationClaimWriteRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories.UserOperationClaims;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IUserOperationClaimWriteRepository interface TODO: Describe class here
/// </summary>
public interface IUserOperationClaimWriteRepository : IWriteRepository<UserOperationClaim>
{

}
