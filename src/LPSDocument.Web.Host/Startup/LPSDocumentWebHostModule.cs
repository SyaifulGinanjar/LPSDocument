using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LPSDocument.Configuration;

namespace LPSDocument.Web.Host.Startup
{
    [DependsOn(
       typeof(LPSDocumentWebCoreModule))]
    public class LPSDocumentWebHostModule: AbpModule
    {
        private readonly IWebHostEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public LPSDocumentWebHostModule(IWebHostEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LPSDocumentWebHostModule).GetAssembly());
        }
    }
}
