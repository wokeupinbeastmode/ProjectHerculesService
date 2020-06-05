using System;
using System.Collections.Generic;

namespace ProjectHerculesService.Data.Models
{
    public partial class Sales
    {
        public Sales() { }

        public int Id { get; set; }
        public string TotalMonthly { get; set; }
        public string TotalYearly { get; set; }
        public string PercentChangeSalesMonth { get; set; }
        public string PercentChangeSalesYear { get; set; }
        public int SalesTypeId { get; set; }
        public string PercentChangeByType { get; set; }
        public string CustomerCount  { get; set; }
        public string PercentChangeCustomer { get; set; }
        public string Month { get; set; }   


        public virtual SalesTypes SalesTypes { get; set; }
    }
}
