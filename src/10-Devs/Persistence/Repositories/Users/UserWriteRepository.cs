//-------------------------------------------------------------------------------------------------
//
// UserWriteRepository.cs -- The UserWriteRepository class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.Users;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.Users
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The UserWriteRepository class TODO: Describe class here
    /// </summary>
    public class UserWriteRepository : WriteRepository<User, KodlamaIODevsDbContext>, IUserWriteRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public UserWriteRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
