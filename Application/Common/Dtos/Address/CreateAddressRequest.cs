namespace Application.Common.Dtos;

public record CreateAddressRequest
(
    string Line1,
    string? Line2,
    string City,
    string State,
    string Country,
    string Zip
);