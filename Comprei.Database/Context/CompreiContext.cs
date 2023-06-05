using Comprei.Model.Entities;
using Comprei.Model.Entities.DefaultEntity;
using System;
using System.Data.Entity;
using System.Linq;

namespace Comprei.Database.Context
{
    public class CompreiContext : DbContext
    {
        public CompreiContext() : base(GetConnectionString())
        {            
        }

        DbSet<Address> Addresses { get; set; }
        DbSet<Customer> Customers { get; set; }
        DbSet<House> Houses { get; set; }
        DbSet<HouseStorage> HousesStorages { get; set; }
        DbSet<Product> Products { get; set; }
        DbSet<ShoppingList> ShoppingLists { get; set; }
        DbSet<ShoppingProduct> ShoppingProducts { get; set; }


        protected override void OnModelCreating(DbModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }

        public override int SaveChanges()
        {
            var currentTime = DateTime.UtcNow; //check if DateTime.Now is better

            #region Added State Control
            var addedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Added)
                .Select(e => e.Entity)
                .OfType<Entity>()
                .ToList();

            foreach (var entity in addedEntities)
                entity.CreationTime = currentTime;
            #endregion

            #region Modified State Control

            var modifiedEntities = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Modified)
                .Select(e => e.Entity)
                .OfType<Entity>()
                .ToList();

            foreach (var entity in modifiedEntities)
                entity.ModificationTime = currentTime;
            #endregion

            #region Deleted State Control

            var deletedEntrys = ChangeTracker.Entries()
                .Where(e => e.State == EntityState.Deleted)
                .ToList();

            foreach (var entry in deletedEntrys)
            {
                if (entry.Entity is Entity entity)
                {
                    entry.State = EntityState.Modified;
                    entity.Deleted = true;
                    entity.DeletionTime = currentTime;
                }
            }
            #endregion

            return base.SaveChanges();
        }
        
        private static string GetConnectionString()
        {
            string connectionString = "Server=localhost,1433;Database=compreidb;User Id=sa;Password=Compreipass01;";

            //var server = "localhost,5432";
            //var database = "compreidb";
            //var userId = "compreiuser";
            //var password = "compreipass";

            // Build the connection string for Postgre
            // var connectionStringBuilder = new Npgsql.NpgsqlConnectionStringBuilder(connectionString);

            return connectionString;
        }
    }
}
