using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace LPSDocument.EntityFrameworkCore
{
    public static class LPSDocumentDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<LPSDocumentDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<LPSDocumentDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
