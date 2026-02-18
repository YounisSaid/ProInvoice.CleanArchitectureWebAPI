namespace ProInvoice.CleanArchitectureWebAPI.Domain.Abstraction
{
    public abstract class BaseEntity
    {
        protected BaseEntity() { }
        protected BaseEntity(Guid iD)
        {
            ID = iD;
        }

        private readonly List<IDomainEvent> _domainEvents = [];
        public IReadOnlyList<IDomainEvent> GetDomainEvents() => _domainEvents.AsReadOnly();
        public void ClearDomainEvents() => _domainEvents.Clear();
        protected void RaiseDomainEvents(IDomainEvent domainEvent) => _domainEvents.Add(domainEvent);
        public Guid ID { get; init; }
        public byte[] RowVersion { get; set; } = null!;
    }
}
