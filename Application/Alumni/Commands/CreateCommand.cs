using Application.Common.Authentication;
using Application.Common.Dtos;
using ErrorOr;
using MediatR;

namespace Application.Authentication.Commands.Alumni;

public record CreateCommand 
(
    CreateAlumniRequest CreateAlumniRequest
) : IRequest<ErrorOr<CreateAlumniResponse>>;