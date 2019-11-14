using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace Master.Web.Views
{
    public abstract class MasterRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected MasterRazorPage()
        {
            LocalizationSourceName = MasterConsts.LocalizationSourceName;
        }
    }
}
