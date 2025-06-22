using Domain.Models.Events;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace Infrastructure.Persistence.Interceptors;

public class PublishDomainEventInterceptor : SaveChangesInterceptor {

    private readonly IPublisher _mediator;

    public PublishDomainEventInterceptor(IMediator mediator) {
        _mediator = mediator;
    }
    
    public override InterceptionResult<int> SavingChanges(DbContextEventData eventData, InterceptionResult<int> result)
    {
        PublishDomainEvents(eventData.Context).GetAwaiter().GetResult();
        return base.SavingChanges(eventData, result);
    }
    public override async ValueTask<InterceptionResult<int>> SavingChangesAsync(DbContextEventData eventData, InterceptionResult<int> result, CancellationToken cancellationToken = default)
    {
        await PublishDomainEvents(eventData.Context);
        return await base.SavingChangesAsync(eventData, result, cancellationToken);
    }

    private async Task PublishDomainEvents(DbContext? dbContext) {
        if (dbContext is null) {
            return;
        }

        // get hold of all the various entities
        var entities = dbContext.ChangeTracker.Entries<Entity>()
            .Where(entry => entry.Entity.domainEvents.Any())
            .Select(entry => entry.Entity)
            .ToList();

        // get hold of the various domain events
        var domainEvents = entities.SelectMany(entry => entry.domainEvents).ToList();

        
        // clear domain events
        entities.ForEach(entity => entity.ClearDomainEvents() );
        
        // publish domain events
        foreach(var domainEvent in domainEvents) {
            await _mediator.Publish(domainEvent);
        }
    }
}