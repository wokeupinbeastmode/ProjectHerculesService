using System;
using System.Collections.Generic;

namespace ProjectHerculesService.Data.Models
{
    public partial class Months
    {
        public Months()
        {
            Sales = new HashSet<Sales>();
            Years = new HashSet<Years>();
        }

        public int MonthId { get; set; }
        public string Month { get; set; }

        public virtual ICollection<Sales> Sales { get; set; }
        public virtual ICollection<Years> Years { get; set; }
    }
}
