using System.Threading.Tasks;
using ProjectHerculesService.Models;
using ProjectHerculesService.Models.Request;

namespace ProjectHerculesService.Library.Interface
{
    public interface ICreateUserRequestBuilder
    {
        Task<UserInsertRequest> BuildUserRequestAsync(UserModel model);
    }
}