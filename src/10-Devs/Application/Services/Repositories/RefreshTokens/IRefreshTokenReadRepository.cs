//-------------------------------------------------------------------------------------------------
//
// IRefreshTokenReadRepository.cs -- The IRefreshTokenReadRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories.RefreshTokens;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IRefreshTokenReadRepository interface TODO: Describe class here
/// </summary>
public interface IRefreshTokenReadRepository : IReadRepository<RefreshToken>
{

}
