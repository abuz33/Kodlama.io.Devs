//-------------------------------------------------------------------------------------------------
//
// IUserReadRepository.cs -- The IUserReadRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories.Users;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IUserReadRepository interface TODO: Describe class here
/// </summary>
public interface IUserReadRepository : IReadRepository<User>
{

}
