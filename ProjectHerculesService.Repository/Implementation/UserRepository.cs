using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjectHerculesService.Data.Models;
using ProjectHerculesService.DTO;
using ProjectHerculesService.Models;
using ProjectHerculesService.Repository.Extensions;
using ProjectHerculesService.Repository.Interface;

namespace ProjectHerculesService.Repository.Implementation
{
    public class UserRepository : IUserRepository
    {
        private readonly IContextContainer _context;

        public UserRepository(IContextContainer context)
        {
            _context = context;
        }

        public async Task<UserModel> InsertUserAsync(UserModel model)
        {
            UserModel result;

            using (var context = _context.GetHerculesServiceContextInstance())
            {
                User user = model.ToDomain();

                await context.User.AddAsync(user);
                await context.SaveChangesAsync();

                result = user.ToModel();
            }

            return result;
        }

        public async Task<UserModel> GetUserAsync(int id)
        {
            UserModel result;

            using (var context = _context.GetHerculesServiceContextInstance())
            {
                User user = new User();

                user = await context.User.FindAsync(id);

                result = user.ToModel();
            }

            return result;
        }

        public async Task<List<UserModel>> GetAllUsersAsync()
        {
            List<UserModel> result;

            using (var context = _context.GetHerculesServiceContextInstance())
            {
                List<User> users = new List<User>();
                users = await context.User.ToListAsync();

                result = users.ToModel();
            }

            return result;
        }
    }
}