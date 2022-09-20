//-------------------------------------------------------------------------------------------------
//
// SocialMedia.cs -- The SocialMedia class.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;

namespace Domain.Entities;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The SocialMedia class TODO: Describe class here
/// </summary>
public class SocialMedia : Entity
{
    public Guid DeveloperId { get; set; }
    public string Name { get; set; }
    public string Url { get; set; }

    public virtual Developer Developer { get; set; }

    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public SocialMedia ()
    {
    }

    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public SocialMedia (Guid id, Guid developerId, string name, string url) : base(id)
    {
        DeveloperId = developerId;
        Name = name;
        Url = url;
    }
}
