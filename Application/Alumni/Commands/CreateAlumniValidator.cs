using Application.Authentication.Commands.Alumni;
using FluentValidation;

namespace Application.Authentication.Commands.Alumni;

public class CreateAlumniValidator : AbstractValidator<CreateCommand> {
    public CreateAlumniValidator() {
        RuleFor(x => x.CreateAlumniRequest.Contact).NotEmpty();
    }
}