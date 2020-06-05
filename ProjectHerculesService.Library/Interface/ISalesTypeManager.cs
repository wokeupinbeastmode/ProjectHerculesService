using System.Threading.Tasks;
using ProjectHerculesService.Models;
using ProjectHerculesService.Models.Request;
using ProjectHerculesService.Models.Response;

namespace ProjectHerculesService.Library.Interface
{
    public interface ISalesTypeManager
    {
        Task<SalesTypeGetResponse> GetSalesTypeAsync(SalesTypeGetRequest request);
        Task<SalesTypeGetResponse> CreateSalesTypeAsync(SalesTypesModel request);
        //Task<SalesTypeInsertRequest> BuildSalesTypeAsync(SalesTypesModel model);
        Task<SalesTypesGetResponse> GetAllSalesTypesAsync();
    }
}