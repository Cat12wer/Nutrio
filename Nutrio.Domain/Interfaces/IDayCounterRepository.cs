using Nutrio.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Nutrio.Domain.Interfaces
{
    internal interface IDayCounterRepository : IRepository<DayCounter>
    {
       Task<IEnumerable<DayCounter>> GetByUserIdIdAndAsync(Guid userId, DateTime Date);
    }
}
