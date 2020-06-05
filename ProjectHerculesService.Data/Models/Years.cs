using System;
using System.Collections.Generic;

namespace ProjectHerculesService.Data.Models
{
    public partial class Years
    {
        public int YearId { get; set; }
        public string Year { get; set; }
        public int? SalesId { get; set; }
        public int? MonthId { get; set; }

        public virtual Months Month { get; set; }
    }
}
