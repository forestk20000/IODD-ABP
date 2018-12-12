using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using IODD.Authorization.Roles;
using IODD.Authorization.Users;
using IODD.MultiTenancy;

namespace IODD.EntityFrameworkCore
{
    public class IODDDbContext : AbpZeroDbContext<Tenant, Role, User, IODDDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public IODDDbContext(DbContextOptions<IODDDbContext> options)
            : base(options)
        {
        }
    }
}
