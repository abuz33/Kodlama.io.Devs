//-------------------------------------------------------------------------------------------------
//
// IDeveloperWriteRepository.cs -- The IDeveloperWriteRepository interface.
//
//-------------------------------------------------------------------------------------------------

using Core.Persistence.Repositories;
using Domain.Entities;

namespace Application.Services.Repositories.Developers;

//---------------------------------------------------------------------------------------------
/// <summary>
/// The IDeveloperWriteRepository interface TODO: Describe class here
/// </summary>
public interface IDeveloperWriteRepository : IWriteRepository<Developer>
{

}
