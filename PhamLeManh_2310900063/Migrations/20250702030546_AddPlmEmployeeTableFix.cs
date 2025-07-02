using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PhamLeManh_2310900063.Migrations
{
    /// <inheritdoc />
    public partial class AddPlmEmployeeTableFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "PlmEmployees",
                columns: table => new
                {
                    PlmEmpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlmEmpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlmEmpLevel = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PlmEmpStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    PlmEmpStatus = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlmEmployees", x => x.PlmEmpId);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PlmEmployees");
        }
    }
}
