namespace OrderService.Domain.Core.Entities
{
    public abstract class BaseEntity 
        : IBaseEntity
    {
        public virtual int Id { get; set; }
    }
}
