//-------------------------------------------------------------------------------------------------
//
// IOperationClaimWriteRepository.cs -- The IOperationClaimWriteRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories.OperationClaims;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IOperationClaimWriteRepository interface TODO: Describe class here
/// </summary>
public interface IOperationClaimWriteRepository : IWriteRepository<OperationClaim>
{

}
