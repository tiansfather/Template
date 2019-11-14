using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Master.Authorization.Roles;
using Master.Authorization.Users;
using Master.MultiTenancy;

namespace Master.EntityFrameworkCore
{
    public class MasterDbContext : AbpZeroDbContext<Tenant, Role, User, MasterDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MasterDbContext(DbContextOptions<MasterDbContext> options)
            : base(options)
        {
        }
    }
}
