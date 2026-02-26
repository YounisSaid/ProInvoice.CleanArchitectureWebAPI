using ProInvoice.CleanArchitectureWebAPI.Domain.Abstraction;

namespace ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Products.Events
{
    public record class ProductCreatedDomainEvent(Guid ProductId) : IDomainEvent;

}
