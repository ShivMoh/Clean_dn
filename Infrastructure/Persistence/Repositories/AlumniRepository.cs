using Application.Common.Interfaces.Persistence;
using Domain.Common.Models;
using Domain.Entities;
using Domain.Entities.Events;
using Domain.Models.Events;
using Infrastructure.DataContext;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Persistence.Repository;

public class AlumniRepository : IRepository
{
    private readonly ApplicationDbContext _dbContext;

    public AlumniRepository(ApplicationDbContext dbContext) {
        _dbContext = dbContext;
    }    

    public void Add(Entity entity)
    {        

        Alumni? alumni = entity as Alumni;

        if (alumni is null) {
            throw new Exception("Must be type alumni");
        }
        
        UserCategory userCategory = new UserCategory {
            Type = UserType.BASIC
        };

        User user = new User {
            Email = alumni.Contact.EmailAddress,
            Password = alumni.BiographicalInformation.FirstName
        };

        user.UserCategoryId = userCategory.Id;
    
        alumni.BiographicalInformation.UserId = user.Id;
        alumni.BiographicalInformation.User = user;

        _dbContext.Add(userCategory);
        _dbContext.Add(user);
        _dbContext.Add(alumni);

        return;
    }

}