using OrderService.Domain.Core.Entities;
using OrderService.Domain.Interface;
using OrderService.Infra.Core.Repositories;

namespace OrderService.Infra.Repositories
{
    public class PartRepository : Repository<Part>, IPartRepository
    {
        public PartRepository()
        {
            SeedParts();
        }

        public void SeedParts()
        {
            _entities.Add(new Part { Id = 1, Description = "Wire", Price = 85.99M, Quantity = 5 });
            _entities.Add(new Part { Id = 2, Description = "Brake Fluid", Price = 4.90M, Quantity = 20 });
            _entities.Add(new Part { Id = 3, Description = "Engine Oil ", Price = 5M, Quantity = 12 });
        }
    }
}
