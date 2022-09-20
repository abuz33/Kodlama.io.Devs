//-------------------------------------------------------------------------------------------------
//
// IOperationClaimsReadRepository.cs -- The IOperationClaimsReadRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories.OperationClaims;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IOperationClaimsReadRepository interface TODO: Describe class here
/// </summary>
public interface IOperationClaimReadRepository : IReadRepository<OperationClaim>
{

}
