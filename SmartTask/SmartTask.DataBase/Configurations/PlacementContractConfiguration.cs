using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartTask.Models.Entities;

namespace SmartTask.DataBase.Configurations
{
    public class PlacementContractConfiguration : IEntityTypeConfiguration<PlacementContract>
    {
        public void Configure(EntityTypeBuilder<PlacementContract> builder)
        {
            builder.ToTable("placementContract")
                   .HasKey(e => e.Id);

            builder.HasOne(e => e.Premises)
                   .WithMany(pr => pr.Contracts)
                   .HasForeignKey(e => e.PremisesId);

            builder.HasOne(e => e.EquipmentType)
                   .WithMany(eq => eq.Contracts)
                   .HasForeignKey(e => e.EquipmentTypeId);
        }
    }
}
