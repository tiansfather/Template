using System.Collections.Generic;
using Master.Roles.Dto;
using Master.Users.Dto;

namespace Master.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
