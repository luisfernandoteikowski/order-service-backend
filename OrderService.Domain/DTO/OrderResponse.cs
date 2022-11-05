using OrderService.Domain.Core.Entities;

namespace OrderService.Domain.DTO
{
    public class OrderResponse
    {
        public OrderResponse(Order entity)
        {
            Id = entity.Id;
            Parts = entity.Parts.Select(p => new OrderPartResponse(p)).ToList();
            Total = entity.Total;
        }

        public int Id { get; set; }
        public IList<OrderPartResponse> Parts { get; set; }
        public decimal Total { get; set; }
    }

    public class OrderPartResponse
    {
        public OrderPartResponse(Part entity)
        {
            if (entity == null)
                return;

            Id = entity.Id;
            Description = entity.Description;
            Price = entity.Price;
            Quantity = entity.Quantity;
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
    }
}
