using ProjectHerculesService.Library.Interface;
using ProjectHerculesService.Models;
using ProjectHerculesService.Models.Extensions;
using ProjectHerculesService.Models.Request;

namespace ProjectHerculesService.Library.Implementation.Builders
{
    public class SalesTypeBuilder : ISalesTypeBuilder
    {
        public SalesTypeInsertRequest BuildSalesTypeAsync(SalesTypesModel model)
        {
            SalesTypeInsertRequest request = new SalesTypeInsertRequest();

            if (model != null)
            {
                request = model.ToRequest();
            }

            return request;
        }
    }
}