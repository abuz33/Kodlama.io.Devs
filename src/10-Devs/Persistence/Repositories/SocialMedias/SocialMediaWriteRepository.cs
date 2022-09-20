//-------------------------------------------------------------------------------------------------
//
// SocialMediaWriteRepository.cs -- The SocialMediaWriteRepository class.
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
    /// The SocialMediaWriteRepository class TODO: Describe class here
    /// </summary>
    public class SocialMediaWriteRepository : WriteRepository<SocialMedia, KodlamaIODevsDbContext>, ISocialMediaWriteRepository
    {
        //---------------------------------------------------------------------------------------------
        /// <summary>
        /// The constructor
        /// </summary>
        public SocialMediaWriteRepository (KodlamaIODevsDbContext context) : base(context)
        {
        }

    }
}
