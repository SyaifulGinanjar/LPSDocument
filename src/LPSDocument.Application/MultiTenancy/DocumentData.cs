using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LPSDocument.MultiTenancy
{
    public class DocumentData : Entity<Guid>
    {
        public string NamaDokumen { get; set; }
        public string Extension { get; set; }
        public string Path { get; set; }

    }
}
