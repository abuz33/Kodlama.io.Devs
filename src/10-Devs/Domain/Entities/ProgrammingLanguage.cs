//-------------------------------------------------------------------------------------------------
//
// ProgrammingLanguage.cs -- The ProgrammingLanguage class.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;

namespace Domain.Entities;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The ProgrammingLanguage class TODO: Describe class here
/// </summary>
public class ProgrammingLanguage : Entity
{
    public string Name { get; set; }
    public virtual ICollection<Framework> Frameworks { get; set; }

    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public ProgrammingLanguage ()
    {
    }

    //---------------------------------------------------------------------------------------------
    /// <summary>
    /// The constructor
    /// </summary>
    public ProgrammingLanguage (Guid id, string name) : base(id)
    {
        this.Name = name;
    }
}
