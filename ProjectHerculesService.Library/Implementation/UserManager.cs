using System;
using System.Net;
using System.Threading.Tasks;
using ProjectHerculesService.Library.Interface;
using ProjectHerculesService.Repository.Interface;
using ProjectHerculesService.Models;
using ProjectHerculesService.Models.Request;
using ProjectHerculesService.Models.Response;


namespace ProjectHerculesService.Library.Implementation
{
    public class UserManager : IUserManager
    {
        private readonly IUserRepository _userRepository;
        private readonly IDependencyContainer _container;

        public UserManager(
            IUserRepository userRepository, 
            IDependencyContainer container)
        {
            _userRepository = userRepository;
            _container = container;
        }

        public async Task<UserGetResponse> GetUserAsync(UserGetRequest request)
        {
            UserGetResponse response = new UserGetResponse();

            try
            {
                 if (request != null)
                 {
                     response.User = await _userRepository.GetUserAsync(request.UserId);
                     response.Success = true;
                     response.HttpStatusCode = HttpStatusCode.OK;

                 }
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("UserManager, GetUserAsync", ex);
                throw;
            }

            return response;
        }

        public async Task<InsertUserResponse> InsertUserAsync(UserModel model)
        {
            InsertUserResponse response = new InsertUserResponse();

            try
            {
                if (model != null)
                {
                    var userRequestBuilder = _container.GetInstance<ICreateUserRequestBuilder>();
                    var request = await userRequestBuilder.BuildUserRequestAsync(model);

                    response.User = await _userRepository.InsertUserAsync(request.User);
                    response.Success = true;
                    response.HttpStatusCode = HttpStatusCode.OK;
                }
            }
            catch (Exception ex)
            {
                //_logger.LogError("UserManager, InsertUserAsync", ex); //Microsoft logger is not working. It cant be instantiated in the CompositionRoot
                Console.Out.WriteLine("UserManager, InsertUserAsync", ex);
                throw;
            }

            return response;
        }

        public async Task<AllUsersGetResponse> GetAllUsersAsync()
        {
            AllUsersGetResponse response = new AllUsersGetResponse();

            try
            {
                response.Users = await _userRepository.GetAllUsersAsync();
                response.Success = true;
                response.HttpStatusCode = HttpStatusCode.OK;
            }
            catch (Exception ex)
            {
                Console.Out.WriteLine("UserManager, GetAllUsersAsync", ex);
                throw;
            }

            return response;
        }
        
    }
}