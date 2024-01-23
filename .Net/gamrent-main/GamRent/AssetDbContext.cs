using GamRent.Model;
using GamRent.Models;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
//using System.Data.Entity;

namespace GamRent
{
    [System.Data.Entity.DbConfigurationType(typeof(MySqlConfiguration))]
    public class AssetDbContext : DbContext
    {
        //private static readonly CrudContextFactory crudContextFactory= new CrudContextFactory();
        //private IDataService<User> _userService=new DataService<User>(crudContextFactory);
        public AssetDbContext(DbContextOptions<AssetDbContext> options) : base(options) { }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var connection = SystemConstants.LocalConnectionString;
                optionsBuilder.UseMySql(SystemConstants.LocalConnectionString, ServerVersion.AutoDetect(connection));
            }
            
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            AddUser(modelBuilder);
        }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Rental> Rentals { get; set; }
        public virtual DbSet<Asset> Assets { get; set; }
        public virtual DbSet<AssetType> AssetTypes { get; set; }
        public virtual DbSet<Model.Maintenance> Maintenances { get; set; }
        public virtual DbSet<AssetCategory> AssetCategories { get; set; }
        public virtual DbSet<Models.Tenants> Tenants { get; set; }
        public virtual DbSet<RentalCategory> RentalCategories { get; set; }
        public void AddUser(ModelBuilder builder)
        {
            User user = new User()
            {
                Id = Guid.NewGuid(),
                Name="Admin Account",
                FirstName="Admin",
                LastName="Admin",
                Email="admin@gmail.com",
                Password= Encryption.Encrypt("admin"),
                Phone="1234567",
                UserName="admin",
                Role ="admin"
            };
            builder.Entity<User>().HasData(user);

        }
    }

}
