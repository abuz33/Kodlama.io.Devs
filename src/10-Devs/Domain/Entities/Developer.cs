//-------------------------------------------------------------------------------------------------
//
// Developer.cs -- The Developer class.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Core.Security.Entities;

namespace Domain.Entities;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The Developer class TODO: Describe class here
/// </summary>
public class Developer : Entity
{
    public Guid UserId { get; set; }

    public virtual User User { get; set; }
    public virtual ICollection<SocialMedia> SocialMedias { get; set; }
 
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public Developer ()
    {
    }
    
    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public Developer (Guid id, Guid userId) : base(id)
    {
        UserId = userId;
    }

}
