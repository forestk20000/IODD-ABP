using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace IODD.EntityFrameworkCore
{
    public static class IODDDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<IODDDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<IODDDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
