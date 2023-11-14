using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace LPSDocument.Controllers
{

    public abstract class LPSDocumentControllerBase: AbpController
    {
        protected LPSDocumentControllerBase()
        {
            LocalizationSourceName = LPSDocumentConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
