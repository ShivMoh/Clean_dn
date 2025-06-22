using Domain.Common.Models;

namespace Domain.Models.Events;

public class Entity
{
    public Guid Id = Guid.NewGuid();

    public ICollection<IDomainEvent> domainEvents = new List<IDomainEvent>();
    public void AddDomainEvent(IDomainEvent domainEvent)
    {
        domainEvents.Add(domainEvent);
    }

    public void ClearDomainEvents()
    {
        domainEvents.Clear();
    }
}
