using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LPSDocument.Authorization;

namespace LPSDocument
{
    [DependsOn(
        typeof(LPSDocumentCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class LPSDocumentApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<LPSDocumentAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(LPSDocumentApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddMaps(thisAssembly)
            );
        }
    }
}
