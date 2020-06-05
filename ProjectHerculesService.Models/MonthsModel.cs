
namespace ProjectHerculesService.Models
{
    public class MonthsModel
    {
        public MonthsModel()
        {
           SalesModel Sales = new SalesModel();
           YearsModel Years = new YearsModel();
        }

        public int MonthId { get; set; }
        public string Month { get; set; }

    }
}
