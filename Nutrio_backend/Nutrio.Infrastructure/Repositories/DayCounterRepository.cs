using Microsoft.EntityFrameworkCore;
using Nutrio.Domain.Entities;
using Nutrio.Domain.Interfaces;

namespace Nutrio.Infrastructure.Repositories
{
    public class DayCounterRepository : GenericRepository<DayCounter>, IDayCounterRepository
    {
        public DayCounterRepository(NutrioDbContext context) : base(context)
        {
        }

        public async Task<IEnumerable<DayCounter>> GetByUserIdAndDateAsync(Guid userId, DateTime date)
        {
            return await _context.DayCounters
                .Where(d => d.UserId == userId && d.Date.Date == date.Date)
                .Include(d => d.Product) 
                .ToListAsync();
        }

    }
}