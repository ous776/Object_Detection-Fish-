using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System.Configuration;

namespace GamRent
{
    public class CrudContextFactory :IDesignTimeDbContextFactory<AssetDbContext>
    {
        public CrudContextFactory() { }
       
        public AssetDbContext CreateDbContext()
        {
            var options = new DbContextOptionsBuilder<AssetDbContext>();
            options.UseMySql(SystemConstants.LocalConnectionString, ServerVersion.AutoDetect(SystemConstants.LocalConnectionString));
            return new AssetDbContext(options.Options);
        }

        public AssetDbContext CreateDbContext(string[] args)
        {
            var options = new DbContextOptionsBuilder<AssetDbContext>();
            options.UseMySql(SystemConstants.LocalConnectionString, ServerVersion.AutoDetect(SystemConstants.LocalConnectionString));
            return new AssetDbContext(options.Options);
        }

        public AssetDbContext CreateSQLDbContext()
        {
            var options = new DbContextOptionsBuilder<AssetDbContext>();
            options.UseSqlServer(SystemConstants.LocalConnectionString);
            return new AssetDbContext(options.Options);
        }
    }

}
