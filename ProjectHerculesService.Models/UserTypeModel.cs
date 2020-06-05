using System.Collections.Generic;

namespace ProjectHerculesService.Models
{
    public class UserTypeModel
    {
        public UserTypeModel()
        {
          UserModel User = new UserModel();
        }

        public int UserTypeId { get; set; }
        public string Title { get; set; }
        public bool IsManager { get; set; }

    }
}
