namespace ProjectHerculesService.Models
{
    public class UserModel
    {
       //public int UserId { get; set; } //These are auto generated. The user does not have to submit one. 
        public string UserName { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        //public int UserTypeId { get; set; } //Auto-generated for default user types 

   }
}
