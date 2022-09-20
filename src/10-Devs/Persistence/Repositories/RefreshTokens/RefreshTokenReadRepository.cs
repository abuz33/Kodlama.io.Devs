//-------------------------------------------------------------------------------------------------
//
// RefreshToken.cs -- The RefreshToken class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.RefreshTokens;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.RefreshTokens
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The RefreshTokenReadRepository class TODO: Describe class here
    /// </summary>
    public class RefreshTokenReadRepository : ReadRepository<RefreshToken, KodlamaIODevsDbContext>, IRefreshTokenReadRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public RefreshTokenReadRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
