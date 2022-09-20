//-------------------------------------------------------------------------------------------------
//
// IUserWriteRepository.cs -- The IUserWriteRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Application.Services.Repositories.Users;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IUserWriteRepository interface TODO: Describe class here
/// </summary>
public interface IUserWriteRepository : IWriteRepository<User>
{

}
