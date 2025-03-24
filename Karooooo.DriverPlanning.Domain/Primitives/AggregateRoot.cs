using Karooooo.Common.Domain.Core;
using Karooooo.DriverPlanning.Domain.Primitives;
using System.ComponentModel.DataAnnotations.Schema;

namespace Karooooo.AccessManagement.Domain.Primitives;

public abstract class AggregateRoot<TIdentity> : Entity<TIdentity>, IAuditableEntity where TIdentity : IIdentity
{
    private readonly List<IDomainEvent> _domainEvents = new();

    protected AggregateRoot(TIdentity uid) : base(uid)
    {
    }

    public IReadOnlyCollection<IDomainEvent> GetDomainEvents() => _domainEvents.ToList();

    public void ClearDomainEvents() => _domainEvents.Clear();

    protected void RaiseDomainEvent(IDomainEvent domainEvent) =>
        _domainEvents.Add(domainEvent);


    public bool IsDeleted { get; protected set; }

    public DateTime CreatedAtUtc { get; protected set; }
    [Column(TypeName = "varchar(100)")]
    public string? CreatedBy { get; protected set; }
    public DateTime? UpdatedAtUtc { get; protected set; }
    [Column(TypeName = "varchar(100)")]
    public string? UpdatedBy { get; protected set; }
}

public abstract class AggregateRoot : Entity
{
    private readonly List<IDomainEvent> _domainEvents = new();

    protected AggregateRoot(Guid id)
        : base(id)
    {
    }

    public IReadOnlyCollection<IDomainEvent> GetDomainEvents() => _domainEvents.ToList();

    public void ClearDomainEvents() => _domainEvents.Clear();

    protected void RaiseDomainEvent(IDomainEvent domainEvent) =>
        _domainEvents.Add(domainEvent);
}
