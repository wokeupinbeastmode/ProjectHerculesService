using System.Runtime.Serialization;

namespace ProjectHerculesService.DTO
{
    [DataContract(Namespace ="")]
    public class UserTypeDTO
    {
        [DataMember]
        public string Title { get; set; }

        [DataMember]
        public bool IsManager { get; set; }
    }
}