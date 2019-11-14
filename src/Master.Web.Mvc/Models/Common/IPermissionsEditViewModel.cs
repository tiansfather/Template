using System.Collections.Generic;
using Master.Roles.Dto;

namespace Master.Web.Models.Common
{
    public interface IPermissionsEditViewModel
    {
        List<FlatPermissionDto> Permissions { get; set; }
    }
}