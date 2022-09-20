//-------------------------------------------------------------------------------------------------
//
// IRefreshTokenWriteRepository.cs -- The IRefreshTokenWriteRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories.RefreshTokens;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IRefreshTokenWriteRepository interface TODO: Describe class here
/// </summary>
public interface IRefreshTokenWriteRepository : IWriteRepository<RefreshToken>
{

}
