using OrderService.Domain.DTO;

namespace OrderService.Domain.Services.Order
{
    public class OrderCalculateItemTotal
    {
        public virtual decimal CalculateItemTotal(int quantity, decimal price)
        {
            var itemPriceXQuantity = (quantity * price);
            var gst = 15;
            var total = itemPriceXQuantity + (itemPriceXQuantity * gst) / 100;
            return total;
        }

        public void SetReponseItemTotal(OrderResponse orderResponse)
        {
            foreach (var p in orderResponse.Parts)
            {
                p.Total = CalculateItemTotal(p.Quantity, p.Price);
            }
        }
    }
}
