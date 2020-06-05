using System;
using System.Collections.Generic;

namespace ProjectHerculesService.Data.Models
{
    public partial class UserType
    {
        public UserType()
        {
            User = new HashSet<User>();
        }

        public int UserTypeId { get; set; }
        public string Title { get; set; }
        public bool IsManager { get; set; }

        public virtual ICollection<User> User { get; set; }
    }
}
