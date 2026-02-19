namespace ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Customers.ValueObjects
{
    public record class Address(
                                string FirstLineAddress,
                                string? SecondLineAddress,
                                string PostCode,
                                string City,
                                string Country);

}
