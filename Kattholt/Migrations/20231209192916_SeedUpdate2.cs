using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kattholt.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdate2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CatTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdoptedTime", "TurnedInTime" },
                values: new object[] { new DateTime(2023, 12, 9, 20, 29, 16, 285, DateTimeKind.Local).AddTicks(9340), new DateTime(2023, 12, 9, 20, 29, 16, 285, DateTimeKind.Local).AddTicks(9300) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CatTransactions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "AdoptedTime", "TurnedInTime" },
                values: new object[] { null, new DateTime(2023, 12, 9, 20, 27, 55, 599, DateTimeKind.Local).AddTicks(4600) });
        }
    }
}
