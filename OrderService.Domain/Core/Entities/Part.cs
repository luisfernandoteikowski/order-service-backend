namespace OrderService.Domain.Core.Entities
{
    public class Part : BaseEntity
    {
        public virtual int Id { get; set; }
        public virtual string Description { get; set; }
        public virtual decimal Price { get; set; }
        public virtual int Quantity { get; set; }
    }
}
