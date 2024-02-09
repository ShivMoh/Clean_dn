using Application.Common.Authentication;
using Application.Common.Interfaces.Persistence;
using MediatR;

namespace Application.Authentication.Commands.Register;

public class RegisterCommandHandler : IRequestHandler<RegisterCommand, AuthenticationResponse>
{

    private readonly IUserRepository _userRepository;

    public RegisterCommandHandler(IUserRepository userRepository)
    {
        _userRepository = userRepository;
    }

    public async Task<AuthenticationResponse> Handle(RegisterCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;

        if (_userRepository.GetUserByEmail(request.Email) is not null)
        {
            return new AuthenticationResponse(
                false,
                request.Email,
                request.Password
            );
        }

        return new AuthenticationResponse(
            true,
            request.Email,
            request.Password
        );

    }
}
