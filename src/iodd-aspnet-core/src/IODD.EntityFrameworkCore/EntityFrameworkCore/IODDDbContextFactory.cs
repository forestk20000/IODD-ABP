using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using IODD.Configuration;
using IODD.Web;

namespace IODD.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class IODDDbContextFactory : IDesignTimeDbContextFactory<IODDDbContext>
    {
        public IODDDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<IODDDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            IODDDbContextConfigurer.Configure(builder, configuration.GetConnectionString(IODDConsts.ConnectionStringName));

            return new IODDDbContext(builder.Options);
        }
    }
}
