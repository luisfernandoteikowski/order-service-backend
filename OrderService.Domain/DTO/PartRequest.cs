using OrderService.Domain.Core.Entities;

namespace OrderService.Domain.DTO
{
    public class PartRequest
    {
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }

        public Part ToEntity()
        {
            return new Part()
            {
                Description = Description,
                Price = Price,
                Quantity = Quantity
            };
        }
    }
}
