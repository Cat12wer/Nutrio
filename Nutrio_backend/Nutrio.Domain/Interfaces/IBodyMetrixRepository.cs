using Nutrio.Domain.Entities;

namespace Nutrio.Domain.Interfaces
{
    public interface IBodyMetrixRepository : IRepository<Bodymetrix>
    {
        Task<Bodymetrix?> GetLatestByUserIdAsync(Guid userId);


    }
}
