//-------------------------------------------------------------------------------------------------
//
// User.cs -- The User class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.Users;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.Users;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The UserReadRepository class TODO: Describe class here
/// </summary>
public class UserReadRepository : ReadRepository<User, KodlamaIODevsDbContext>, IUserReadRepository
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public UserReadRepository (KodlamaIODevsDbContext context) : base(context)
    {
    }

}
