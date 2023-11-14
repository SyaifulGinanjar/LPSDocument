using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using LPSDocument.Authorization.Roles;
using LPSDocument.Authorization.Users;
using LPSDocument.MultiTenancy;

namespace LPSDocument.EntityFrameworkCore
{
    public class LPSDocumentDbContext : AbpZeroDbContext<Tenant, Role, User, LPSDocumentDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<DocumentData> documentData {  get; set; }
        public LPSDocumentDbContext(DbContextOptions<LPSDocumentDbContext> options)
            : base(options)
        {
        }
    }
}
