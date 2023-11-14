using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;


namespace LPSDocument.Domain
{
    public class DocumentAppService : IDocumentAppService
    {
        public async Task<bool> UploadFileAsync(Guid id, string name, IFormFile file)
        {
            var stream = new MemoryStream();
            file.OpenReadStream().CopyTo(stream);
            int chunckSize = 2097152; //2MB
            int totalChunks = (int)(file.Length / chunckSize);
            if (file.Length % chunckSize != 0)
            {
                totalChunks++;
            }

            for (int i = 0; i < totalChunks; i++)
            {
                long position = (i * (long)chunckSize);
                int toRead = (int)Math.Min(file.Length - position, chunckSize);
                byte[] buffer = new byte[toRead];

                await stream.ReadAsync(buffer, 0, buffer.Length);

                using (MultipartFormDataContent form = new MultipartFormDataContent())
                {
                    form.Add(new ByteArrayContent(buffer), "files", name);
                    form.Add(new StringContent(id.ToString()), "id");
                    var meta = JsonConvert.SerializeObject(new ChunkMetaData
                    {
                        UploadUid = id.ToString(),
                        FileName = name,
                        ChunkIndex = i,
                        TotalChunks = totalChunks,
                        TotalFileSize = file.Length,
                        ContentType = "application/unknown"
                    });
                    form.Add(new StringContent(meta), "metaData");

                    var filePath = Path.Combine(Directory.GetCurrentDirectory() + "/Uploads", file.FileName);
                    using (var s = new FileStream(filePath, FileMode.Create))
                    {
                        await file.CopyToAsync(s);
                    }
                    return true;
                }
            }
            return true;
        }
    }
}
