namespace Application.Common.Dtos;

public record CreateBiologicalInformationRequest
(
    string FirstName,
    string LastName,
    string DateOfBirth
);