using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmartTask.DataBase.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "equipmentType",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Area = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_equipmentType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "productionPremises",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StandartArea = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_productionPremises", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "placementContract",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PremisesId = table.Column<int>(type: "int", nullable: false),
                    EquipmentTypeId = table.Column<int>(type: "int", nullable: false),
                    EquipmentCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_placementContract", x => x.Id);
                    table.ForeignKey(
                        name: "FK_placementContract_equipmentType_EquipmentTypeId",
                        column: x => x.EquipmentTypeId,
                        principalTable: "equipmentType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_placementContract_productionPremises_PremisesId",
                        column: x => x.PremisesId,
                        principalTable: "productionPremises",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_placementContract_EquipmentTypeId",
                table: "placementContract",
                column: "EquipmentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_placementContract_PremisesId",
                table: "placementContract",
                column: "PremisesId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "placementContract");

            migrationBuilder.DropTable(
                name: "equipmentType");

            migrationBuilder.DropTable(
                name: "productionPremises");
        }
    }
}
