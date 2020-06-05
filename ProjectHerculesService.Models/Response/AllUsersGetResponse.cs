using System.Collections.Generic;

namespace ProjectHerculesService.Models.Response
{
    public class AllUsersGetResponse : BaseResponse
    {
        public List<UserModel> Users { get; set; }
    }
}