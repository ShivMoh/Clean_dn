using Application.Authentication.Commands.Alumni;
using Application.Authentication.Commands.Register;
using Application.Common.Authentication;
using Application.Common.Dtos;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

public class AlumniController : MainController
{

    IMediator _mediator;

    public AlumniController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpPost("Create")]
    public async Task<IActionResult> Create(CreateAlumniRequest request) {
        var command = new CreateCommand(request);
        
        var result = await _mediator.Send(command);

        return result.Match(
            validResult => Ok(result.Value),
            errors => Problem(errors)
        );
        
    }

    [HttpPut("Update")]

    public async Task<IActionResult> Update(CreateAlumniRequest request) {
        return Ok();
    }
}