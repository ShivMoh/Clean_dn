using Domain.Entities;

namespace Application.Common.Interfaces.Persistence;

public interface IUnitOfWork
{
 
    public void SaveChanges();
    
}