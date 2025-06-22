using Domain.Entities;

namespace Application.Common.Dtos;

public record CreateGenderRequest
(
    GenderType Type
);