using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPSDocument.Domain
{
    public interface IDocumentAppService
    {
        Task<bool> UploadFileAsync(Guid id, string name, IFormFile file);

    }
}
