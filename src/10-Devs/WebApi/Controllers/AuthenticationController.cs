using Application.Features.Authentication.Commands.LoginCommand;
using Application.Features.Authentication.Commands.RegisterCommand;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class AuthenticationController : BaseController
{
    // GET: api/<AuthenticationController>
    [AllowAnonymous]
    [HttpPost("register")]
    public async Task<IActionResult> Register ([FromBody] RegisterCommand registerCommand)
    {
        var result = await Mediator.Send(registerCommand);
        return Created("", result);
    }

    [AllowAnonymous]
    [HttpPost("login")]
    public async Task<IActionResult> Login ([FromBody] LoginCommand loginCommand)
    {
        var result = await Mediator.Send(loginCommand);
        return Ok(result);
    }

    [HttpPost("refresh-token-login")]
    public async Task<IActionResult> Login ([FromBody] RefreshTokenLoginCommand refreshTokenLoginCommand)
    {
        var result = await Mediator.Send(refreshTokenLoginCommand);
        return Ok(result);
    }
}
