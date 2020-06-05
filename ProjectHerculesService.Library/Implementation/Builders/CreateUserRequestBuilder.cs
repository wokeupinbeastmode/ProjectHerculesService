using System.Threading.Tasks;
using ProjectHerculesService.Library.Interface;
using ProjectHerculesService.Models;
using ProjectHerculesService.Models.Request;

namespace ProjectHerculesService.Library.Implementation.Builders
{
    public class CreateUserRequestBuilder : ICreateUserRequestBuilder
    {
        public async Task<UserInsertRequest> BuildUserRequestAsync(UserModel model)
        {
            UserInsertRequest request = new UserInsertRequest();

            if (model != null)
            {
                request.User.FirstName = model.FirstName;
                request.User.LastName = model.LastName;
                request.User.UserName = model.UserName;
                request.User.Password = model.Password;
            }

            return request;
        }
    }
}