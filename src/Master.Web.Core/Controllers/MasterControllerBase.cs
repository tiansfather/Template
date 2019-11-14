using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Master.Controllers
{
    public abstract class MasterControllerBase: AbpController
    {
        protected MasterControllerBase()
        {
            LocalizationSourceName = MasterConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
