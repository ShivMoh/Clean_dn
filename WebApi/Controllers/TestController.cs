using Application.Authentication.Commands.Register;
using Application.Common.Authentication;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class TestController : MainController
{

    IMediator _mediator;

    public TestController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("get")]
    public async Task<IActionResult> Test()
    {
        await Task.CompletedTask;
        return Ok("Testing successful...");
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register(RegisterRequest request)
    {
        var command = new RegisterCommand(request.FirstName, request.LastName, request.Email, request.Password);

        var result = await _mediator.Send(command);

        return Ok(result);
    }
}