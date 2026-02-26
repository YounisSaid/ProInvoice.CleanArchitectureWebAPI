using ProInvoice.CleanArchitectureWebAPI.Domain.Abstraction;
using ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Customers.Dtos;
using ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Customers.Events;
using ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Customers.ValueObjects;
using ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Shared;

namespace ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Customers
{
    public sealed class Customer : BaseEntity
    {
        private Customer(Address address, Title title, Money balance)
        {
            Address = address;
            Title = title;
            Balance = balance;
        }

        private Customer() { }

        public Address Address { get; private set; } = null!;
        public Title Title { get; private set; } = null!;
        public Money Balance { get; private set; } = null!;

        // Invoice Here Search_Later 
        public static Customer Create(CreateCustomerDto request)
        {
            var customer = new Customer(
                                        new Address(request.FirstLineAddress,
                                        request.SecondLineAddress,
                                        request.PostCode,
                                        request.City,
                                        request.Country),
                                        new Title(request.Title),
                                        new Money(0));

            customer.RaiseDomainEvents(new CustomerCreatedDomainEvent(customer.ID));

            return customer;
        }

        public void Update(UpdateCustomerDto request)
        {
            Address = new Address(request.FirstLineAddress,
                                        request.SecondLineAddress,
                                        request.PostCode,
                                        request.City,
                                        request.Country);
            Title = new Title(request.Title);

        }

    }
}
