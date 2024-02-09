using Domain.Entities;

namespace Application.Common.Interfaces.Persistence;

public interface IUserRepository
{
    public User? GetUserByEmail(string email);

    void Add(User user);

    public User? ValidateCredentials(string email, string password);
}