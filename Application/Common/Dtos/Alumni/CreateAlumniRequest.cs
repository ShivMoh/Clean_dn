using Domain.Entities;

namespace Application.Common.Dtos;

public record CreateAlumniRequest
(
    CreateMaritalStatusRequest MaritalStatus,
    CreateAddressRequest Address,
    CreateContactRequest Contact,
    CreateGenderRequest Gender,
    CreateOccupationRequest Occupation,
    CreateBiologicalInformationRequest BiographicalInformation
);