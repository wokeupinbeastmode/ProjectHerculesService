using System.Collections.Generic;
using ProjectHerculesService.DTO;

namespace ProjectHerculesService.Models.Response
{
    public class SalesTypesGetResponse : BaseResponse
    {
        public List<SalesTypesModel> SaleTypes { get; set; }
    }
}