using ProjectHerculesService.Models;
using ProjectHerculesService.Models.Request;

namespace ProjectHerculesService.Library.Interface
{
    public interface ISalesTypeBuilder
    {
        SalesTypeInsertRequest BuildSalesTypeAsync(SalesTypesModel model);
    }
}