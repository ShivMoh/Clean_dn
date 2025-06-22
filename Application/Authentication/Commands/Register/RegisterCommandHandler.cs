using Application.Common.Authentication;
using Application.Common.Interfaces.Persistence;
using Domain.Common.Errors;
using Domain.Entities;
using ErrorOr;
using MediatR;

namespace Application.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, ErrorOr<AuthenticationResponse>>
{
    private readonly IUserRepository _userRepository;
    public RegisterCommandHandler(
        IUserRepository userRepository
        ) {
        _userRepository = userRepository;
    }

    public async Task<ErrorOr<AuthenticationResponse>> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        if (_userRepository.GetUserByEmail(request.Email) is not null)
        {
            return Errors.User.DuplicateEmail;
        }

        User user = new User
        {
            Email = request.Email,
            Password = request.Password
        };

        _userRepository.Add(user);
        
        return new AuthenticationResponse(
            true,
            request.Email,
            request.Password
        );
    }
}
