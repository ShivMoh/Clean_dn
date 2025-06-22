using System.Xml.XPath;
using Application.Authentication.Commands.Register;
using Application.Common.Authentication;
using FluentValidation;
using MediatR;

namespace Application.Common.Behaviors;

public class ValidationBehaviour<TRequest, TResponse> : IPipelineBehavior<TRequest, TResponse> 
                                                        where TRequest : IRequest<TResponse>                            
{

    private readonly IValidator<TRequest>? _validator;

    public ValidationBehaviour(IValidator<TRequest> validator) {
        _validator = validator;
    }

    public async Task<TResponse> Handle(TRequest request, RequestHandlerDelegate<TResponse> next, CancellationToken cancellationToken)
    {
        if (_validator is null) {
            var result = await next();
            return result;
        }
        
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
