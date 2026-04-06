using Nutrio.Domain.Entities;
using Nutrio.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Nutrio.Infrastructure.Repositories
{
    public class BodyMetrixRepository : GenericRepository<Bodymetrix>, IBodyMetrixRepository
    {
        public BodyMetrixRepository(NutrioDbContext context) : base(context){ }
        public async Task<Bodymetrix?> GetLatestByUserIdAsync(Guid userId)
        {
                 return await _context.BodymetrixRecords
                .Where(x => x.UserId == userId)
                .OrderByDescending(x => x.DateOfEntryMetrix)
                .FirstOrDefaultAsync<Bodymetrix>();
        }
       
    }
}