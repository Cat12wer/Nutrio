using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        IProductIRepositor Products { get; }
        IBodyMetrixIRepository Bodymetrix { get; }
        IDayCounterRepository DayCounters { get; }

        Task<int> SaveChangesAsync();
    }
}
