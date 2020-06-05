using System.Runtime.Serialization;

namespace ProjectHerculesService.DTO
{
    [DataContract(Namespace = "")]
    public class MonthsDTO
    {
        [DataMember]
        public string Month { get; set; }
    }
}