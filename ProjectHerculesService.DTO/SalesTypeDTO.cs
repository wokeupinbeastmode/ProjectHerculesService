using System.Runtime.Serialization;

namespace ProjectHerculesService.DTO
{
    [DataContract(Namespace="")]
    public class SalesTypeDTO
    {
        [DataMember]
        public string TypeName { get; set; }

        [DataMember]
        public string SalesByType { get; set; }
    }
}