using OrderService.Domain.Core.Entities;

namespace OrderService.Domain.DTO
{
    public class PartResponse
    {
        public PartResponse()
        {
        }

        public PartResponse(Part entity)
        {
            if (entity == null)
                return;

            Id = entity.Id;
            Description = entity.Description;
            Price = entity.Price;
            Quantity = entity.Quantity;
        }

        public int  Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
