using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Authorization;
using Abp.Authorization.Users;
using Abp.MultiTenancy;
using Abp.Runtime.Security;
using LPSDocument.Authentication.JwtBearer;
using LPSDocument.Authorization;
using LPSDocument.Authorization.Users;
using LPSDocument.Models.TokenAuth;
using LPSDocument.MultiTenancy;
using LPSDocument.Domain;
using Microsoft.AspNetCore.Http;

namespace LPSDocument.Controllers
{
    [Route("api/[controller]/[action]")]
    public class DocumentController : LPSDocumentControllerBase
    {

        private readonly IDocumentAppService documentAppService;

        public DocumentController(IDocumentAppService documentAppService)
        {
            this.documentAppService = documentAppService;
        }


        [HttpPost]
        public async Task<IActionResult> UploadDocument([FromForm] IFormFile model)
        {
            var result = await documentAppService.UploadFileAsync(
                new Guid(),
                "File",
                model
            );

            return Ok(result);
        }
    }
}
