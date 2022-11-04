using OrderService.Domain.Core.Entities;

namespace OrderService.Domain.Core.Interfaces
{
    public interface IRepositoryGetById<T>
       where T : BaseEntity
    {
        Task<T> GetById(object id);
        Task<TDTO> GetById<TDTO>(object id);
    }
}
