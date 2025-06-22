using Application.Authentication.Commands.Alumni;
using Application.Authentication.Commands.Register;
using Application.Common.Authentication;
using Application.Common.Dtos;
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

        return result.Match(
            validResult => Ok(result.Value),
            errors => Problem(errors)
        );
    }

    [HttpPost("CreateAlumni")]
    public async Task<IActionResult> CreateAlumni(CreateAlumniRequest request) {
        var command = new CreateCommand(request);
        
        var result = await _mediator.Send(command);

        return result.Match(
            validResult => Ok(result.Value),
            errors => Problem(errors)
        );
        
    }
}