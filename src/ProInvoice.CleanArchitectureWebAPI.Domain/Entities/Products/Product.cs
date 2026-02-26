using ProInvoice.CleanArchitectureWebAPI.Domain.Abstraction;
using ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Products.Dtos;
using ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Products.Events;
using ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Shared;

namespace ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Products
{
    public sealed class Product : BaseEntity
    {
        private Product()
        {
        }

        private Product(Guid Id,
                       Title descreption,
                       Money unitPrice)
        {
            Description = descreption;
            UnitPrice = unitPrice;
        }

        public Title Description { get; private set; } = null!;
        public Money UnitPrice { get; private set; } = null!;

        public static Product Create(CreateProductDto request)
        {
            var product = new Product(Guid.NewGuid(),
                                      new Title(request.Description),
                                      new Money(0));

            product.RaiseDomainEvents(new ProductCreatedDomainEvent(product.ID));

            return product;
        }

        public void Update(UpdateProductDto request)
        {
            Description = new Title(request.Description);
            UnitPrice = new Money(request.UnitPrice);
        }

    }
}
