using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using Master.Authorization;

namespace Master
{
    [DependsOn(
        typeof(MasterCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class MasterApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<MasterAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(MasterApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
