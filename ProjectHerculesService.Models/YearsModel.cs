using System.Collections.Generic;

namespace ProjectHerculesService.Models
{
    public class YearsModel
    {
        public YearsModel()
        {
            SalesModel Sales = new SalesModel();
        }

        public int YearId { get; set; }
        public string Year { get; set; }
        public int MonthId { get; set; }

        //public virtual MonthsModel Month { get; set; }
        //public virtual ICollection<SalesModel> Sales { get; set; }
    }
}
