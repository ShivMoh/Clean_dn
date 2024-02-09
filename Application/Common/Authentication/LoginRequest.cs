namespace Application.Common.Authentication;

public record LoginRequest
(
    string Email,
    string Password
);