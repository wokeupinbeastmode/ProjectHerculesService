using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectHerculesService.DTO;
using ProjectHerculesService.Models;

namespace ProjectHerculesService.Repository.Interface
{
    public interface IUserRepository
    {
        Task<UserModel> InsertUserAsync(UserModel model);
        Task<UserModel> GetUserAsync(int id);
        Task<List<UserModel>> GetAllUsersAsync();
    }
}