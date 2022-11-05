
namespace OrderService.Domain.Core.Entities
{
    public class Order : BaseEntity
    {
        public IList<Part> Parts { get; set; }
        public decimal Total { get; set; }
    }
}
