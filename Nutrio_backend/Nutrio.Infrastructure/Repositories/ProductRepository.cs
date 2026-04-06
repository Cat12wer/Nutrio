using Nutrio.Domain.Entities;
using Nutrio.Domain.Interfaces;

namespace Nutrio.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepository<Products>, IProductRepository
    {
        public ProductRepository(NutrioDbContext context) : base(context)
        {
        }
    }
}