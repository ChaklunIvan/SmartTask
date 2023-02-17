using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartTask.Models.Entities;

namespace SmartTask.DataBase.Configurations
{
    public class ProductionPremisesConfiguration : IEntityTypeConfiguration<ProductionPremises>
    {
        public void Configure(EntityTypeBuilder<ProductionPremises> builder)
        {
            builder.ToTable("productionPremises")
                   .HasKey(p => p.Id);

            builder.HasMany(p => p.Contracts)
                   .WithOne(c => c.Premises);
        }
    }
}
