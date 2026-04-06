using Nutrio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Domain.Interfaces
{
    public interface IDayCounterRepository : IRepository<DayCounter>
    {
       Task<IEnumerable<DayCounter>> GetByUserIdAndDateAsync(Guid userId, DateTime Date);
    }
}
