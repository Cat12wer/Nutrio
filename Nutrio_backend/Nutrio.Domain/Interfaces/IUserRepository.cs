using Nutrio.Domain.Entities;

namespace Nutrio.Domain.Interfaces
{
    public interface IUserRepository : IRepository<Users>
    {
        Task<bool> IsEmailUniqueAsync(string email);
        Task<Users?> GetByEmailAsync(string email);
    }
}
