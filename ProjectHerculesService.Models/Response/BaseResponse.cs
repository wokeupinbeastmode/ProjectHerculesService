using System.Net;

namespace ProjectHerculesService.Models.Response
{
    public class BaseResponse
    {
        public HttpStatusCode HttpStatusCode { get; set; }
        public bool Success { get; set; }
    }
}