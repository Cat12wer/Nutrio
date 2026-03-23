using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository User { get; }
        IProductIRepository Products { get; }
        IBodyMetrixRepository Bodymetrix { get; }
        IDayCounterRepository DayCounters { get; }

        Task<int> SaveChangesAsync();
    }
}
