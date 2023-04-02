using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace HTFPersistence.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ConsumptionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ConsumptionTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "EmissionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "longtext", nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmissionTypes", x => x.Id);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "ElectricEnergyConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    KwQuantity = table.Column<double>(type: "double", nullable: false),
                    ConsumptionTypeId = table.Column<int>(type: "int", nullable: false),
                    EmissionTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ElectricEnergyConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ElectricEnergyConsumptions_ConsumptionTypes_ConsumptionTypeId",
                        column: x => x.ConsumptionTypeId,
                        principalTable: "ConsumptionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ElectricEnergyConsumptions_EmissionTypes_EmissionTypeId",
                        column: x => x.EmissionTypeId,
                        principalTable: "EmissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "FuelConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    GallonQuantity = table.Column<double>(type: "double", nullable: false),
                    ConsumptionTypeId = table.Column<int>(type: "int", nullable: false),
                    EmissionTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_FuelConsumptions_ConsumptionTypes_ConsumptionTypeId",
                        column: x => x.ConsumptionTypeId,
                        principalTable: "ConsumptionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_FuelConsumptions_EmissionTypes_EmissionTypeId",
                        column: x => x.EmissionTypeId,
                        principalTable: "EmissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "PetrolDerivedConsumptions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Quantity = table.Column<double>(type: "double", nullable: false),
                    ConsumptionTypeId = table.Column<int>(type: "int", nullable: false),
                    EmissionTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    ModifiedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PetrolDerivedConsumptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PetrolDerivedConsumptions_ConsumptionTypes_ConsumptionTypeId",
                        column: x => x.ConsumptionTypeId,
                        principalTable: "ConsumptionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PetrolDerivedConsumptions_EmissionTypes_EmissionTypeId",
                        column: x => x.EmissionTypeId,
                        principalTable: "EmissionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "ConsumptionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Administrativo" },
                    { 2, "Indirecto de proveedor" },
                    { 3, "Logístico" },
                    { 4, "Distribución" },
                    { 5, "Operación" }
                });

            migrationBuilder.InsertData(
                table: "EmissionTypes",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { 1, "Directa" },
                    { 2, "Indirecta" },
                    { 3, "Otra indirecta" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ElectricEnergyConsumptions_ConsumptionTypeId",
                table: "ElectricEnergyConsumptions",
                column: "ConsumptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_ElectricEnergyConsumptions_EmissionTypeId",
                table: "ElectricEnergyConsumptions",
                column: "EmissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelConsumptions_ConsumptionTypeId",
                table: "FuelConsumptions",
                column: "ConsumptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelConsumptions_EmissionTypeId",
                table: "FuelConsumptions",
                column: "EmissionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PetrolDerivedConsumptions_ConsumptionTypeId",
                table: "PetrolDerivedConsumptions",
                column: "ConsumptionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_PetrolDerivedConsumptions_EmissionTypeId",
                table: "PetrolDerivedConsumptions",
                column: "EmissionTypeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ElectricEnergyConsumptions");

            migrationBuilder.DropTable(
                name: "FuelConsumptions");

            migrationBuilder.DropTable(
                name: "PetrolDerivedConsumptions");

            migrationBuilder.DropTable(
                name: "ConsumptionTypes");

            migrationBuilder.DropTable(
                name: "EmissionTypes");
        }
    }
}
