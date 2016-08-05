using System.Threading.Tasks;
using Lunchorder.Domain.Entities.Authentication;

namespace Lunchorder.Common.Interfaces
{
    public interface IUserService
    {
        Task<ApplicationUser> Create(string username, string email);
    }
}