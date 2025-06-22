using Domain.Entities.Events;
using MediatR;

namespace Application.Authentication.Events;

public class DummyHandler : INotificationHandler<UserCreated>
{
    public async Task Handle(UserCreated notification, CancellationToken cancellationToken)
    {
        await Task.CompletedTask;
    }
}