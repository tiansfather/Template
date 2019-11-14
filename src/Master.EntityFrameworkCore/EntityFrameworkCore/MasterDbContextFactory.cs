using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using Master.Configuration;
using Master.Web;

namespace Master.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class MasterDbContextFactory : IDesignTimeDbContextFactory<MasterDbContext>
    {
        public MasterDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<MasterDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            MasterDbContextConfigurer.Configure(builder, configuration.GetConnectionString(MasterConsts.ConnectionStringName));

            return new MasterDbContext(builder.Options);
        }
    }
}
