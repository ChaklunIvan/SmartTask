using Microsoft.EntityFrameworkCore;
using SmartTask.DataBase.Configurations;
using SmartTask.Models.Entities;

namespace SmartTask.DataBase
{
    public class SmartTaskDbContext : DbContext
    {
        public DbSet<ProductionPremises> Premises { get; set; }
        public DbSet<EquipmentType> Equipments { get; set; }
        public DbSet<PlacementContract> Contracts { get; set; }

        public SmartTaskDbContext(DbContextOptions options)
            : base(options) { }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ProductionPremisesConfiguration());
            builder.ApplyConfiguration(new EquipmentTypeConfiguration());
            builder.ApplyConfiguration(new PlacementContractConfiguration());
        }
    }
}