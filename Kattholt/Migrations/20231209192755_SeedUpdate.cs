using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kattholt.Migrations
{
    /// <inheritdoc />
    public partial class SeedUpdate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CatTransactions",
                columns: new[] { "Id", "AdoptedTime", "CatId", "NewOwnerId", "OldOwnerId", "TurnedInTime" },
                values: new object[] { 1, null, 1, 2, 1, new DateTime(2023, 12, 9, 20, 27, 55, 599, DateTimeKind.Local).AddTicks(4600) });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "AddressId", "CatId", "Name" },
                values: new object[] { 2, 1, 1, "Fannar" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatTransactions",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
