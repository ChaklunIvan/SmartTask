using Microsoft.EntityFrameworkCore;
using SmartTask.Models.Entities;

namespace SmartTask.DataBase.Configurations
{
    public static class DataSeed
    {
        public static void Seed(this ModelBuilder builder)
        {
            builder.Entity<ProductionPremises>().HasData(
                new ProductionPremises() { Id = 1, Name = "Warehouse", StandartArea = 2000 },
                new ProductionPremises() { Id = 2, Name = "Workshop", StandartArea = 1000 },
                new ProductionPremises() { Id = 3, Name = "Kitchen", StandartArea = 100 },
                new ProductionPremises() { Id = 4, Name = "Hangar", StandartArea = 1200 },
                new ProductionPremises() { Id = 5, Name = "Shed", StandartArea = 500 });

            builder.Entity<EquipmentType>().HasData(
                new EquipmentType() { Id = 1, Name = "Technological Machines", Area = 800 },
                new EquipmentType() { Id = 2, Name = "Computing Devices", Area = 100 },
                new EquipmentType() { Id = 3, Name = "Industrial Furnaces", Area = 350 },
                new EquipmentType() { Id = 4, Name = "Equipment for thermal processing of food products", Area = 50 },
                new EquipmentType() { Id = 5, Name = "Machine tools", Area = 1000 },
                new EquipmentType() { Id = 6, Name = "Aggregate installation", Area = 750 });

            builder.Entity<PlacementContract>().HasData(
                new PlacementContract() { Id = 1, PremisesId = 3, EquipmentTypeId = 4, EquipmentCount = 2 },
                new PlacementContract() { Id = 2 ,PremisesId = 5, EquipmentTypeId = 2, EquipmentCount = 4 });
        }
    }
}
