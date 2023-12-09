using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Kattholt.Migrations
{
    /// <inheritdoc />
    public partial class ModelsAdded : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    StreetName = table.Column<string>(type: "TEXT", maxLength: 255, nullable: false),
                    HouseNumer = table.Column<int>(type: "INTEGER", nullable: false),
                    ZipCode = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Cats",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    TrackingNumber = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cats", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Owners",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    AddressId = table.Column<int>(type: "INTEGER", nullable: false),
                    CatId = table.Column<int>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Owners", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Owners_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Owners_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "CatTransactions",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    CatId = table.Column<int>(type: "INTEGER", nullable: false),
                    OldOwnerId = table.Column<int>(type: "INTEGER", nullable: false),
                    NewOwnerId = table.Column<int>(type: "INTEGER", nullable: true),
                    TurnedInTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    AdoptedTime = table.Column<DateTime>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CatTransactions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CatTransactions_Cats_CatId",
                        column: x => x.CatId,
                        principalTable: "Cats",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CatTransactions_Owners_NewOwnerId",
                        column: x => x.NewOwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_CatTransactions_Owners_OldOwnerId",
                        column: x => x.OldOwnerId,
                        principalTable: "Owners",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CatTransactions_CatId",
                table: "CatTransactions",
                column: "CatId");

            migrationBuilder.CreateIndex(
                name: "IX_CatTransactions_NewOwnerId",
                table: "CatTransactions",
                column: "NewOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_CatTransactions_OldOwnerId",
                table: "CatTransactions",
                column: "OldOwnerId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_AddressId",
                table: "Owners",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Owners_CatId",
                table: "Owners",
                column: "CatId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CatTransactions");

            migrationBuilder.DropTable(
                name: "Owners");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "Cats");
        }
    }
}
