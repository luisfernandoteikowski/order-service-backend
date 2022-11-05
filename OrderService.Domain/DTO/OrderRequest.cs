using OrderService.Domain.Core.Entities;

namespace OrderService.Domain.DTO
{
    public class OrderRequest
    {
        public IList<OrderItemRequest> Parts { get; set; }

        public Order ToEntity()
        {
            return new Order()
            {
                Parts = Parts.Select(x => x.ToEntity()).ToList()
            };
        }
    }

    public class OrderItemRequest
    {
        public int Id { get; set; }
        public string? Description { get; set; }
        public decimal? Price { get; set; }
        public int Quantity { get; set; }

        public void SetData(string description, decimal price)
        {
            Description = description;
            Price = price;
        }

        public Part ToEntity()
        {
            return new Part()
            {
                Id = Id,
                Description = Description,
                Price = Price.GetValueOrDefault(),
                Quantity = Quantity
            };
        }
    }
}
