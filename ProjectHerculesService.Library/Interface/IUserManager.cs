using ProjectHerculesService.Models;
using System.Threading.Tasks;
using ProjectHerculesService.DTO;
using ProjectHerculesService.Models.Request;
using ProjectHerculesService.Models.Response;

namespace ProjectHerculesService.Library.Interface
{
    public interface IUserManager
    {
        Task<InsertUserResponse> InsertUserAsync(UserModel request);
        Task<UserGetResponse> GetUserAsync(UserGetRequest request);
        Task<AllUsersGetResponse> GetAllUsersAsync();
    }
}