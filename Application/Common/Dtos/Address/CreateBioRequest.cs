namespace Application.Common.Dtos;

public record CreateContactRequest
(
    string? MobileNumber,
    string? HomeNumber,
    string? WorkNumber,
    string? EmailAddress
);