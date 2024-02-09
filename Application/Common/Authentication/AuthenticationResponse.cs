namespace Application.Common.Authentication;

public record AuthenticationResponse 
(
    bool Success,
    string Email,
    string Password
);