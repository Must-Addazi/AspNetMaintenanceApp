using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MantenanceProjetASPNET6.Migrations
{
    /// <inheritdoc />
    public partial class mMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PhotoDiplomePath",
                table: "Diplomes",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "test5",
                column: "DateInscription",
                value: new DateTime(2025, 1, 9, 0, 42, 9, 983, DateTimeKind.Local).AddTicks(6946));

            migrationBuilder.UpdateData(
                table: "Diplomes",
                keyColumn: "Cne",
                keyValue: "test5",
                column: "PhotoDiplomePath",
                value: null);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PhotoDiplomePath",
                table: "Diplomes");

            migrationBuilder.UpdateData(
                table: "Candidats",
                keyColumn: "Cne",
                keyValue: "test5",
                column: "DateInscription",
                value: new DateTime(2025, 1, 7, 20, 40, 51, 94, DateTimeKind.Local).AddTicks(2705));
        }
    }
}
