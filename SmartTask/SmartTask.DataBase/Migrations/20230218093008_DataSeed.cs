using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SmartTask.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class DataSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "equipmentType",
                columns: new[] { "Id", "Area", "Name" },
                values: new object[,]
                {
                    { 1, 800.0, "Technological Machines" },
                    { 2, 100.0, "Computing Devices" },
                    { 3, 350.0, "Industrial Furnaces" },
                    { 4, 50.0, "Equipment for thermal processing of food products" },
                    { 5, 1000.0, "Machine tools" },
                    { 6, 750.0, "Aggregate installation" }
                });

            migrationBuilder.InsertData(
                table: "productionPremises",
                columns: new[] { "Id", "Name", "StandartArea" },
                values: new object[,]
                {
                    { 1, "Warehouse", 2000.0 },
                    { 2, "Workshop", 1000.0 },
                    { 3, "Kitchen", 100.0 },
                    { 4, "Hangar", 1200.0 },
                    { 5, "Shed", 500.0 }
                });

            migrationBuilder.InsertData(
                table: "placementContract",
                columns: new[] { "Id", "EquipmentCount", "EquipmentTypeId", "PremisesId" },
                values: new object[,]
                {
                    { 1, 2, 4, 3 },
                    { 2, 4, 2, 5 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "equipmentType",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "equipmentType",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "equipmentType",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "equipmentType",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "placementContract",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "placementContract",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "productionPremises",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "productionPremises",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "productionPremises",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "equipmentType",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "equipmentType",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "productionPremises",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "productionPremises",
                keyColumn: "Id",
                keyValue: 5);
        }
    }
}
