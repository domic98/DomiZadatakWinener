using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DomiZadatakWin.Migrations
{
    /// <inheritdoc />
    public partial class AddPartnerAndPolicyToDbAndSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Partners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CroatianPIN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PartnerTypeId = table.Column<int>(type: "int", nullable: false),
                    CreatedAtUtc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreateByUser = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsForeign = table.Column<bool>(type: "bit", nullable: true),
                    ExternalCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Gender = table.Column<string>(type: "nvarchar(1)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Partners", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Policies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PolicyNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PolicyAmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PartnerId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Policies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Policies_Partners_PartnerId",
                        column: x => x.PartnerId,
                        principalTable: "Partners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Partners",
                columns: new[] { "Id", "Address", "CreateByUser", "CreatedAtUtc", "CroatianPIN", "ExternalCode", "FirstName", "Gender", "IsForeign", "LastName", "PartnerNumber", "PartnerTypeId" },
                values: new object[,]
                {
                    { 1, "Adresa 190", "john@example.com", new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(666), "12345678901", "ABC1238663564", "John", "M", false, "Doe", "12345678901234567890", 1 },
                    { 2, "Adresa 56", "jane@example.com", new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(670), "18344658941", "XYZ4563986685446", "Jane", "F", true, "Doe", "09876543210987654321", 2 },
                    { 3, "Adresa 123", "alice@example.com", new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(672), "47314358990", "DEF789487678756", "Alice", "F", false, "Smith", "11122233344455566677", 1 },
                    { 4, "Adresa 15", "bob@example.com", new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(674), "623478695206", "GHI12345697644", "Bob", "M", true, "Johnson", "44455566677788899900", 2 },
                    { 5, "Adresa 23", "charlie@example.com", new DateTime(2024, 2, 21, 22, 1, 16, 411, DateTimeKind.Utc).AddTicks(676), "70345653248", "JKL45634754656", "Charlie", "N", false, "Brown", "99900011122233344455", 1 }
                });

            migrationBuilder.InsertData(
                table: "Policies",
                columns: new[] { "Id", "PartnerId", "PolicyAmount", "PolicyNumber" },
                values: new object[,]
                {
                    { 1, 1, 1500.00m, "POL001" },
                    { 2, 2, 3000.00m, "POL002" },
                    { 3, 3, 2000.00m, "POL003" },
                    { 4, 4, 6000.00m, "POL004" },
                    { 5, 5, 2500.00m, "POL005" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Policies_PartnerId",
                table: "Policies",
                column: "PartnerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Policies");

            migrationBuilder.DropTable(
                name: "Partners");
        }
    }
}
