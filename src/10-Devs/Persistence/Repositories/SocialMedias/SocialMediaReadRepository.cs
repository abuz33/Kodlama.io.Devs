//-------------------------------------------------------------------------------------------------
//
// SocialMedia.cs -- The SocialMedia class.
//
//-------------------------------------------------------------------------------------------------

using Application.Services.Repositories.SocialMedias;
using Core.Persistence.Repositories;
using Domain.Entities;
using Persistence.Contexts;

namespace Persistence.Repositories.SocialMedias
{
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The SocialMediaReadRepository class TODO: Describe class here
    /// </summary>
    public class SocialMediaReadRepository : ReadRepository<SocialMedia, KodlamaIODevsDbContext>, ISocialMediaReadRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public SocialMediaReadRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
