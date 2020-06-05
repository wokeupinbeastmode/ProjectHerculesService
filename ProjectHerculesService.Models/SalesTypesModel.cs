using System.Collections.Generic;

namespace ProjectHerculesService.Models
{
    public class SalesTypesModel
    {
        //public SalesTypesModel()
        //{
        //    SalesModel Sales = new SalesModel();
        //}

        public int SaleTypeId { get; set; }
        public string TypeName { get; set; }
        public string SalesByType { get; set; }

    }
}
