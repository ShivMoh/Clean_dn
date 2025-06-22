using Application.Common.Interfaces.Persistence;
using Domain.Common.Models;
using Domain.Entities;
using Domain.Entities.Events;
using Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repository;

public class UserRepository : IUserRepository
{
    private readonly ApplicationDbContext _dbContext;

    public UserRepository(ApplicationDbContext dbContext) {
        _dbContext = dbContext;
    }    

    public void Add(User user)
    {

        UserCreated userCreated = new UserCreated(user);
        user.AddDomainEvent(userCreated);
        _dbContext.Users.Add(user);
        // _dbContext.SaveChanges();

        return;
    }

    public User? GetUserByEmail(string email)
    {
      
        return _dbContext.Users.FirstOrDefault((user) => user.Email == email);
    }

    public User? ValidateCredentials(string email, string password)
    {
        return _dbContext.Users.FirstOrDefault((user) => user.Email == user.Email && user.Password == user.Password) ?? null;
    }

    public void SaveChanges() {
        _dbContext.SaveChanges();
    }
}