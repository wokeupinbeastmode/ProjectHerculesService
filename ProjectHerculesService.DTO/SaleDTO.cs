using System.Runtime.Serialization;

namespace ProjectHerculesService.DTO
{
    [DataContract(Namespace="")]
    public class SaleDTO
    {
        [DataMember]
        public string TotalMonthly { get; set; }
        
        [DataMember]
        public string TotalYearly { get; set; }

        [DataMember]
        public double PercentChange  { get; set; }
    }
}