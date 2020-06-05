using System;
using System.Collections.Generic;

namespace ProjectHerculesService.Data.Models
{
    public partial class User
    {
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int UserTypeId { get; set; }

        public virtual UserType UserType { get; set; }
    }
}
