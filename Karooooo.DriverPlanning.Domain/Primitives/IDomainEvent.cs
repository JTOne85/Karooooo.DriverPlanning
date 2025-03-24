
using MediatR;

namespace Karooooo.AccessManagement.Domain.Primitives;

public interface IDomainEvent : INotification
{
    public Guid Id { get; init; }
}

public interface IDomainEventData
{
    IReadOnlyCollection<IDomainEvent> GetDomainEvents();

    void ClearDomainEvents();
}
