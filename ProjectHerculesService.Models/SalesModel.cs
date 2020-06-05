namespace ProjectHerculesService.Models
{
    public class SalesModel
    {
        public SalesModel()
        {
            MonthsModel Month = new MonthsModel();
            SalesTypesModel SalesTypes = new SalesTypesModel();
            YearsModel Years = new YearsModel();
        }

        //public int SalesId { get; set; }
        public string TotalMonthly { get; set; }
        public string TotalyYearly { get; set; }
        public string TotalSalesByType { get; set; }
        public string PercentChange { get; set; }
        public int SalesTypeId { get; set; }
        public int MonthId { get; set; }
        public int YearId { get; set; }
    }
}
