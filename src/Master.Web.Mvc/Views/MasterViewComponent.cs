using Abp.AspNetCore.Mvc.ViewComponents;

namespace Master.Web.Views
{
    public abstract class MasterViewComponent : AbpViewComponent
    {
        protected MasterViewComponent()
        {
            LocalizationSourceName = MasterConsts.LocalizationSourceName;
        }
    }
}
