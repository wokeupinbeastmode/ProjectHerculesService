using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectHerculesService.Library.Interface;
using ProjectHerculesService.Models;
using ProjectHerculesService.Models.Request;

namespace ProjectHerculesService.Web.Controllers
{
    public class UserController : Controller
    {
        private readonly IUserManager _userManager;

        public UserController(IUserManager userManager)
        {
            _userManager = userManager;
        }

        // GET
        [HttpGet]
        [Route("User/Index")]
        public IActionResult Index()
        {
            //return Ok("Alive");
            
            return View();
        }

        [HttpPost]
        [Route("User/{Id}")]
        public async Task<IActionResult> GetUserAsync([FromForm] UserGetRequest request)
        {
            var response = await _userManager.GetUserAsync(request);
            return StatusCode((int)response.HttpStatusCode, response);
        }

        [HttpPost]
        [Route("User/Create")]
        public async Task<IActionResult> InsertUserAsync([FromForm] UserModel model)
        {
            var response = await _userManager.InsertUserAsync(model);
            //return StatusCode((int)response.HttpStatusCode, response); //IF this was a service only controller, I would return just the status codes to be passed back to the UI project.
            Console.WriteLine(StatusCode((int) response.HttpStatusCode, response));
            return RedirectToAction("GetAllUsersAsync", "User");
        }

        [HttpGet]
        [Route("Users/All")]
        public async Task<IActionResult> GetAllUsersAsync()
        {
            var response = await _userManager.GetAllUsersAsync();
            //return StatusCode((int) response.HttpStatusCode, response);
            Console.WriteLine(StatusCode((int)response.HttpStatusCode, response));
            return View("Index", response.Users);
        }

        [HttpGet]
        [Route("User/AddUserIndex")]
        public ActionResult AddUserIndex()
        {
            return View("AddUser");
        }
    }
}