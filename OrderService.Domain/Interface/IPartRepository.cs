using OrderService.Domain.Core.Entities;
using OrderService.Domain.Core.Interfaces;

namespace OrderService.Domain.Interface
{
    public interface IPartRepository :
        IBaseRepository,
        IRepositoryGet<Part>,
        IRepositoryInsert<Part>
    {
    }
}
