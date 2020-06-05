using System.Collections.Generic;

namespace ProjectHerculesService.Data.Models
{
    public partial class SalesTypes
    {
        public SalesTypes()
        {
            Sales = new HashSet<Sales>();
        }

        public int SaleTypeId { get; set; }
        public string TypeName { get; set; }
        public string SalesByType { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
    }
}
