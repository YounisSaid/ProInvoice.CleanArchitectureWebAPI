namespace ProInvoice.CleanArchitectureWebAPI.Domain.Entities.Products.Dtos
{
    public class BaseProductDto
    {
        public double UnitPrice { get; set; }
        public string Description { get; set; } = null!;
    }

    public class CreateProductDto : BaseProductDto;
    public class UpdateProductDto : BaseProductDto
    {
        public Guid ProductId { get; set; }
    }

}
