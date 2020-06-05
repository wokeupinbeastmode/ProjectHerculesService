using ProjectHerculesService.Models.Request;

namespace ProjectHerculesService.Library.Interface
{
    public interface IUserBuilder
    {
        //List<UserDTO> GetAllUsers();
       // UserDTO GetUser(UserGetRequest request);
        bool InsertUser(UserInsertRequest request);
    }
}