//using System.Collections.Generic;
//using ProjectHerculesService.DTO;
//using ProjectHerculesService.Gateway.Request;
//using ProjectHerculesService.Library.Interface;
//using ProjectHerculesService.Repository.Implementation;
//using ProjectHerculesService.Repository.Interface;

//namespace ProjectHerculesService.Library.Implementation
//{
//    public class UserBuilder : IUserBuilder
//    {
//        private readonly IUserRepository _userRepository;

//        public UserBuilder(IUserRepository userRepository)
//        {
//            _userRepository = userRepository;
//        }

//        public List<UserDTO> GetAllUsers()
//        {
//            List<UserDTO> users = new List<UserDTO>();

//            users = _userRepository.GetAllUsers(); //TODO MIKE: Need repository COntext code

//            return users;
//        }

//        public UserDTO GetUser(UserGetRequest request)
//        {
//            UserDTO dto = new UserDTO();

//            if (request != null)
//            {
//                dto = _userRepository.GetUser();
//            }

//            return dto;
//        }

//        public bool InsertUser(InsertUserRequest request)
//        {
//            var result = false;

//            if (request != null)
//            {
                
//            }

//            return result;
//        }
//    }
//}