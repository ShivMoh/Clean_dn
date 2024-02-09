namespace Application.Common.Authentication;

public record RegisterRequest
(
  
    string FirstName,
    string LastName,
    string Email,
    string Password,
    string ConfirmPassword
);