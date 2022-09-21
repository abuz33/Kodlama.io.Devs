using Application.Features.ProgrammingLanguages.Commands.CreateCommand;
using Application.Features.ProgrammingLanguages.Commands.DeleteCommand;
using Application.Features.ProgrammingLanguages.Commands.UpdateCommand;
using Application.Features.ProgrammingLanguages.Queries;
using Core.Application.Requests;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ProgrammingLanguageController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Post ([FromBody] CreateProgrammingLanguageCommand createProgrammingLanguageCommand)
    {
        var result = await Mediator.Send(createProgrammingLanguageCommand);
        return Created("", result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList ([FromQuery] PageRequest pageRequest)
    {
        var result = await Mediator.Send(new GetProgrammingLanguageListQuery() { PageRequest = pageRequest });
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> Get ([FromRoute] GetProgrammingLanguageByIdQuery getByIdProgrammingLanguageQuery)
    {
        var result = await Mediator.Send(getByIdProgrammingLanguageQuery);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Get ([FromBody] UpdateProgrammingLanguageCommand updateProgrammingLanguageCommand)
    {
        var result = await Mediator.Send(updateProgrammingLanguageCommand);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Get ([FromQuery] DeleteProgrammingLanguageCommand deleteProgrammingLanguageCommand)
    {
        var result = await Mediator.Send(deleteProgrammingLanguageCommand);
        return Ok(result);
    }
}
