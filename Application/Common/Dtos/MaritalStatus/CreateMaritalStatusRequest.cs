using Domain.Entities;

namespace Application.Common.Dtos;

public record CreateMaritalStatusRequest
(
    MaritalStatusType Type
);