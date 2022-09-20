//-------------------------------------------------------------------------------------------------
//
// Framework.cs -- The Framework class.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;

namespace Domain.Entities;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The Framework class TODO: Describe class here
/// </summary>
public class Framework : Entity
{
    public string Name { get; set; }
    public string? Version { get; set; }
    public Guid ProgrammingLanguageId { get; set; }
    public virtual ProgrammingLanguage ProgrammingLanguage { get; set; }

    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public Framework ()
    {
    }

    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public Framework (string name, string? version, Guid programmingLanguageId)
    {
        Name = name;
        Version = version;
        ProgrammingLanguageId = programmingLanguageId;
    }

    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public Framework (Guid id, Guid programmingLanguageId, string name, string? version) : base(id)
    {
        Name = name;
        Version = version;
        ProgrammingLanguageId = programmingLanguageId;
    }
}
