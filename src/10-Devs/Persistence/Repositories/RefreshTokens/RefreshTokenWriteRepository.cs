//-------------------------------------------------------------------------------------------------
//
// RefreshTokenWriteRepository.cs -- The RefreshTokenWriteRepository class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.RefreshTokens;
using Core.Persistence.Repositories;
using Core.Security.Entities;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.RefreshTokens
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The RefreshTokenWriteRepository class TODO: Describe class here
    /// </summary>
    public class RefreshTokenWriteRepository : WriteRepository<RefreshToken, KodlamaIODevsDbContext>, IRefreshTokenWriteRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public RefreshTokenWriteRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
