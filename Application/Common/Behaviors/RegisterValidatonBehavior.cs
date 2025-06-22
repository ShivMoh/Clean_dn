using System.Xml.XPath;
using Application.Authentication.Commands.Register;
using Application.Common.Authentication;
using FluentValidation;
using MediatR;

namespace Application.Common.Behaviors;

public class RegisterValidatonBehavior : IPipelineBehavior<RegisterCommand, AuthenticationResponse>
{

    private readonly IValidator<RegisterCommand>? _validator;

    public RegisterValidatonBehavior(IValidator<RegisterCommand> validator) {
        _validator = validator;
    }
    
    public async Task<AuthenticationResponse> Handle(RegisterCommand request, RequestHandlerDelegate<AuthenticationResponse> next, CancellationToken cancellationToken)
    {

        var validationResult = await _validator!.ValidateAsync(request, cancellationToken);
 
        if (validationResult.IsValid) {
            var result = await next();
            return result;
        } else {
            var message = validationResult.Errors.First().ErrorMessage;
            throw new Exception(message);
        }

    }
}
