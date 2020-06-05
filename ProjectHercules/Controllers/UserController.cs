using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectHerculesService.Gateway.Request;
using ProjectHerculesService.Gateway.Response;
using ProjectHerculesService.Library.Interface;

namespace ProjectHercules.Controllers
{
    //[Route("api")]
    public class UserController : ControllerBase
    {
        private readonly IUserManager _userManager;
        //private readonly ILogger _logger; //TODO: Build Logger

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        // GET
        [HttpGet]
        [Route("")]
        public IActionResult Index()
        {
            return Ok("Alive");
        }

        //[HttpGet]
        //public AllUsersGetResponse GetAllUsers()
        //{
        //    var response = new AllUsersGetResponse();

        //    try
        //    {
        //        response.Users = _userManager.GetAllUsers();
        //    }
        //    catch (Exception ex)
        //    {
        //        //_logger.Log(ex)
        //        throw;
        //    }

        //    return response;
        //}

        //[HttpGet]
        //public UserGetResponse GetUser(UserGetRequest request)
        //{
        //    var response = new UserGetResponse();

        //    try
        //    {
        //        if (request != null)
        //        {
        //            response.User = _userManager.GetUser(request);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        //_logger.Log(ex);
        //        throw;
        //    }

        //    return response;
        //}

        [HttpPost]
        [Route("User/AddUser")]
        public async Task<IActionResult> InsertUserAsync([FromBody] InsertUserRequest request)
        {
            var response = await _userManager.InsertUserAsync(request);
            return StatusCode((int) response.HttpStatusCode, response);
        }
    }
}