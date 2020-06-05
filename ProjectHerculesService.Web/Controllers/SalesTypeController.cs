using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectHerculesService.Library.Interface;
using ProjectHerculesService.Models;
using ProjectHerculesService.Models.Request;

namespace ProjectHerculesService.Web.Controllers
{
    [Route("SalesType")]
    public class SalesTypeController : Controller
    {
        private readonly ISalesTypeManager _salesTypeManager;

        public SalesTypeController(
            ISalesTypeManager salesTypeManager)
        {
            _salesTypeManager = salesTypeManager;
        }

        [HttpGet]
        [Route("/")]
        public IActionResult Index()
        {
            return Ok("Alive");
        }

        [HttpGet]
        [Route("Index")]
        public ActionResult GetSalesTypeView()
        {
            return View("AddSalesType");
        }

        [HttpGet]
        [Route("SalesTypes")]
        public async Task<ActionResult> GetAllSalesTypes()
        {
            var response = await _salesTypeManager.GetAllSalesTypesAsync();
            //return StatusCode((int)response.HttpStatusCode, response);
            return View("SalesTypes", response);
        }

        [HttpPost]
        [Route("SalesType/{Id}")]
        public async Task<IActionResult> GetSalesTypeAsync([FromForm] SalesTypeGetRequest request)
        {
            var response = await _salesTypeManager.GetSalesTypeAsync(request);
            return StatusCode((int) response.HttpStatusCode, response);
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> CreateSalesTypeAsync([FromForm] SalesTypesModel model)
        {
            var response = await _salesTypeManager.CreateSalesTypeAsync(model);
            return StatusCode((int) response.HttpStatusCode, response);
        }

        //[HttpGet]
        //[Route("Success")]
        //public ActionResult GetSalesTypeSuccess()
        //{
        //    return View("Success");
        //}

        //[HttpGet]
        //[Route("Error")]
        //public ActionResult GetSalesTypeError()
        //{
        //    return View("Error");
        //}
    }
}