namespace OrderService.Domain.Services.Order
{
    public class OrderCalculateItemTotalWithoutFees : OrderCalculateItemTotal
    {
        public override decimal CalculateItemTotal(int quantity, decimal price)
        {
            return quantity * price;
        }
    }
}
