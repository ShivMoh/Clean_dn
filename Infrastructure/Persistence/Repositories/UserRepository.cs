using Application.Common.Interfaces.Persistence;
using Domain.Entities;

namespace Infrastructure.Persistence.Repository;

public class UserRepository : IUserRepository
{
    private static User[] users = 
        [
            new User() {
                Email = "test1@gmail.com",
                Password = "password"
            },

            new User() {
                Email = "test2@gmail.com",
                Password = "passwordaswell"
            }
        ];
        
    public void Add(User user)
    {
        users.Append<User>(user);
        return;
    }

    public User? GetUserByEmail(string email)
    {
        return users.FirstOrDefault((user) => user.Email == email);
    }

    public User? ValidateCredentials(string email, string password)
    {
        return users.FirstOrDefault((user) => user.Email == user.Email && user.Password == user.Password) ?? null;
    }
}