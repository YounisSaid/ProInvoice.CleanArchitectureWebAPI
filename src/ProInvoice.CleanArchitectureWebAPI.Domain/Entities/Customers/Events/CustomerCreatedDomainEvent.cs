using ProInvoice.CleanArchitectureWebAPI.Domain.Abstraction;

namespace ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Customers.Events
{
    public record class CustomerCreatedDomainEvent(Guid CustomerId) : IDomainEvent;

}
