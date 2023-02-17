using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SmartTask.Models.Entities;

namespace SmartTask.DataBase.Configurations
{
    public class EquipmentTypeConfiguration : IEntityTypeConfiguration<EquipmentType>
    {
        public void Configure(EntityTypeBuilder<EquipmentType> builder)
        {
            builder.ToTable("equipmentType")
                   .HasKey(e => e.Id);

            builder.HasMany(e => e.Contracts)
                   .WithOne(c => c.EquipmentType);
        }
    }
}
