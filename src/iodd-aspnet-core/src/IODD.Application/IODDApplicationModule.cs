using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using IODD.Authorization;

namespace IODD
{
    [DependsOn(
        typeof(IODDCoreModule),
        typeof(AbpAutoMapperModule))]
    public class IODDApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<IODDAuthorizationProvider>();

            // 自定义类型映射
            Configuration.Modules.AbpAutoMapper().Configurators.Add(configuration =>
            {
                // XXXMapper.CreateMappers(configuration);


            });
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(IODDApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
