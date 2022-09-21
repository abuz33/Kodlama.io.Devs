using Application.Features.Developers.Commands.CreateCommand;
using Application.Features.Developers.Commands.DeleteCommand;
using Application.Features.Developers.Commands.UpdateCommand;
using Application.Features.Developers.Queries;
using Application.Features.Frameworks.Queries;
using Core.Application.Requests;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DeveloperController : BaseController
{
    [HttpPost]
    public async Task<IActionResult> Post ([FromBody] CreateDeveloperCommand createDeveloperCommand)
    {
        var result = await Mediator.Send(createDeveloperCommand);
        return Created("", result);
    }

    [HttpGet]
    public async Task<IActionResult> GetList ([FromQuery] PageRequest pageRequest)
    {
        var result = await Mediator.Send(new GetDeveloperListQuery() { PageRequest = pageRequest });
        return Ok(result);
    }

    [HttpGet("{Id}")]
    public async Task<IActionResult> Get ([FromRoute] GetDeveloperByIdQuery getByIdDeveloperQuery)
    {
        var result = await Mediator.Send(getByIdDeveloperQuery);
        return Ok(result);
    }

    [HttpPut]
    public async Task<IActionResult> Get ([FromBody] UpdateDeveloperCommand updateDeveloperCommand)
    {
        var result = await Mediator.Send(updateDeveloperCommand);
        return Ok(result);
    }

    [HttpDelete]
    public async Task<IActionResult> Get ([FromQuery] DeleteDeveloperCommand deleteDeveloperCommand)
    {
        var result = await Mediator.Send(deleteDeveloperCommand);
        return Ok(result);
    }
}
