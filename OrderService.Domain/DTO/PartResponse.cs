namespace OrderService.Domain.DTO
{
    public class PartResponse
    {
        public int  Id { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Quantity { get; set; }
    }
}
