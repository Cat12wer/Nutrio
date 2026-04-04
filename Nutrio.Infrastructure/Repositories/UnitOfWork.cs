using Nutrio.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly NutrioDbContext _context;

        // Властивості для кожного репозиторію
        public IUserRepository User { get; private set; }
        public IProductIRepository Products { get; private set; } 
        public IBodyMetrixRepository Bodymetrix { get; private set; }
        public IDayCounterRepository DayCounters { get; private set; }

        public UnitOfWork(NutrioDbContext context)
        {
            _context = context;
            User = new UserRepository(_context);
            Products = new ProductRepository(_context);
            Bodymetrix = new BodyMetrixRepository(_context);
            DayCounters = new DayCounterRepository(_context);
        }

        public async Task<int> SaveChangesAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
