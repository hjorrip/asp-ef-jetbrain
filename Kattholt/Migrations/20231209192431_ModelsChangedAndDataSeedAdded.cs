using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kattholt.Migrations
{
    /// <inheritdoc />
    public partial class ModelsChangedAndDataSeedAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CatTransactions_Owners_NewOwnerId",
                table: "CatTransactions");

            migrationBuilder.DropForeignKey(
                name: "FK_CatTransactions_Owners_OldOwnerId",
                table: "CatTransactions");

            migrationBuilder.DropIndex(
                name: "IX_CatTransactions_NewOwnerId",
                table: "CatTransactions");

            migrationBuilder.DropIndex(
                name: "IX_CatTransactions_OldOwnerId",
                table: "CatTransactions");

            migrationBuilder.AlterColumn<int>(
                name: "NewOwnerId",
                table: "CatTransactions",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "INTEGER",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "Addresses",
                columns: new[] { "Id", "HouseNumer", "StreetName", "ZipCode" },
                values: new object[] { 1, 12, "Hafnargata", 230 });

            migrationBuilder.InsertData(
                table: "Cats",
                columns: new[] { "Id", "Name", "TrackingNumber" },
                values: new object[] { 1, "Kisi", 144354 });

            migrationBuilder.InsertData(
                table: "Owners",
                columns: new[] { "Id", "AddressId", "CatId", "Name" },
                values: new object[] { 1, 1, 1, "Hjörtur" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Owners",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Addresses",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Cats",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.AlterColumn<int>(
                name: "NewOwnerId",
                table: "CatTransactions",
                type: "INTEGER",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "INTEGER");

            migrationBuilder.CreateIndex(
                name: "IX_CatTransactions_NewOwnerId",
                table: "CatTransactions",
                column: "NewOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CatTransactions_OldOwnerId",
                table: "CatTransactions",
                column: "OldOwnerId");

            migrationBuilder.AddForeignKey(
                name: "FK_CatTransactions_Owners_NewOwnerId",
                table: "CatTransactions",
                column: "NewOwnerId",
                principalTable: "Owners",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_CatTransactions_Owners_OldOwnerId",
                table: "CatTransactions",
                column: "OldOwnerId",
                principalTable: "Owners",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
