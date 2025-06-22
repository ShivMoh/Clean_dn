namespace Application.Common.Dtos;

public record CreateOccupationRequest
(
    string OccupationName,
    string Organization,
    string FormerPosition,
    string FormerOrganization
);