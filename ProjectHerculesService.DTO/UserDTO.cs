using System.Runtime.Serialization;

namespace ProjectHerculesService.DTO
{
    [DataContract(Namespace ="")]
    public class UserDTO
    {
        [DataMember]
        public string UserName { get; set; }

        [DataMember]
        public string Password { get; set; }

        [DataMember]
        public string FirstName { get; set; }

        [DataMember]
        public string LastName { get; set; }

        [DataMember]
        public int UserTypeId { get; set; }
    }
}