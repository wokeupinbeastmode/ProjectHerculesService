using System.Collections.Generic;
using System.Threading.Tasks;
using ProjectHerculesService.Data.Models;
using ProjectHerculesService.DTO;
using ProjectHerculesService.Models;

namespace ProjectHerculesService.Repository.Interface
{
    public interface ISalesTypeRepository
    {
        Task<SalesTypesModel> GetSalesTypeAsync(int id);
        //Task<SalesTypeDTO> InsertSalesTypeAsync(SalesTypeDTO dto);
        Task<SalesTypesModel> CreateSalesTypeAsync(SalesTypesModel model);
        Task<List<SalesTypesModel>> GetSalesTypesAsync();
    }
}