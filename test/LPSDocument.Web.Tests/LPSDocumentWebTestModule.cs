using Abp.AspNetCore;
using Abp.AspNetCore.TestBase;
using Abp.Modules;
using Abp.Reflection.Extensions;
using LPSDocument.EntityFrameworkCore;
using LPSDocument.Web.Startup;
using Microsoft.AspNetCore.Mvc.ApplicationParts;

namespace LPSDocument.Web.Tests
{
    [DependsOn(
        typeof(LPSDocumentWebMvcModule),
        typeof(AbpAspNetCoreTestBaseModule)
    )]
    public class LPSDocumentWebTestModule : AbpModule
    {
        public LPSDocumentWebTestModule(LPSDocumentEntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbContextRegistration = true;
        } 
        
        public override void PreInitialize()
        {
            Configuration.UnitOfWork.IsTransactional = false; //EF Core InMemory DB does not support transactions.
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(LPSDocumentWebTestModule).GetAssembly());
        }
        
        public override void PostInitialize()
        {
            IocManager.Resolve<ApplicationPartManager>()
                .AddApplicationPartsIfNotAddedBefore(typeof(LPSDocumentWebMvcModule).Assembly);
        }
    }
}