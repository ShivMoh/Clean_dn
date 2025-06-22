using Domain.Entities;
using Domain.Models.Events;

namespace Application.Common.Interfaces.Persistence;

public interface IRepository
{
   public void Add(Entity entity);
}