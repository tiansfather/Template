using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace Master.EntityFrameworkCore
{
    public static class MasterDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<MasterDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<MasterDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
