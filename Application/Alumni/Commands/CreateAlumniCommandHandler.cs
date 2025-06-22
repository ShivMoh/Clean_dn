using Application.Common.Authentication;
using Application.Common.Dtos;
using Application.Common.Interfaces.Persistence;
using Domain.Common.Errors;
using Domain.Entities;
using ErrorOr;
using MapsterMapper;
using MediatR;

namespace Application.Authentication.Commands.Alumni;

public class CreateAlumniCommandHandler : IRequestHandler<CreateCommand, ErrorOr<CreateAlumniResponse>>
{
    private readonly IMapper _mapper;
    private readonly IRepository _alumniRepositary;

    private readonly IUnitOfWork _unitOfWork;

    // private readonly IUserRepository _userRepositary;
    public CreateAlumniCommandHandler(
        IRepository alumniRepositary,
        IUnitOfWork unitOfWork,
        IMapper mapper
    ) {
        _alumniRepositary = alumniRepositary;
        // _userRepositary = userRepository;
        _unitOfWork = unitOfWork;
        _mapper = mapper;

    }

    public async Task<ErrorOr<CreateAlumniResponse>> Handle(CreateCommand request, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
        
        Contact contact = _mapper.Map<Contact>(request.CreateAlumniRequest.Contact);
        Address address = _mapper.Map<Address>(request.CreateAlumniRequest.Address);
        Gender gender = _mapper.Map<Gender>(request.CreateAlumniRequest.Gender);
        MaritalStatus maritalStatus = _mapper.Map<MaritalStatus>(request.CreateAlumniRequest.MaritalStatus);
        Occupation occupation = _mapper.Map<Occupation>(request.CreateAlumniRequest.Occupation);
        BiographicalInformation biographicalInformation = _mapper.Map<BiographicalInformation>(request.CreateAlumniRequest.BiographicalInformation);

        Domain.Entities.Alumni alumni = new Domain.Entities.Alumni{
            Contact = contact,
            Address = address,
            Gender = gender,
            MaritalStatus = maritalStatus,
            Occupation = occupation,
            BiographicalInformation = biographicalInformation
        };

        _alumniRepositary.Add(alumni);
        _unitOfWork.SaveChanges();
        // _userRepository.SaveChanges();
        // _unitOfWork.SaveChangesAync();
        
        return new CreateAlumniResponse(true);
    
    }
}
