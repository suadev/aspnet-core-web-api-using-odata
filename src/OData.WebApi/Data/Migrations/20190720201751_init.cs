using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace OData.WebApi.Data.Migrations
{
    public partial class init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    CategoryName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(nullable: false),
                    CreatedDate = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    UpdatedDate = table.Column<DateTime>(nullable: false),
                    UpdatedBy = table.Column<string>(nullable: true),
                    ProductName = table.Column<string>(nullable: true),
                    CategoryId = table.Column<Guid>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    Price = table.Column<decimal>(nullable: false),
                    Weight = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_ProductCategory_CategoryId",
                        column: x => x.CategoryId,
                        principalTable: "ProductCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CategoryName", "CreatedBy", "CreatedDate", "UpdatedBy", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("8b726886-e719-413c-a125-939ee5af387d"), "TV", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("1236a458-0802-4340-bdd4-05859c9aaaad"), "Headphones", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { new Guid("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"), "Computers", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "CreatedBy", "CreatedDate", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[,]
                {
                    { new Guid("119cfc7e-37ce-450e-87ba-a3f2dd47f7f1"), new Guid("8b726886-e719-413c-a125-939ee5af387d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "LG 32-Inch 720p LED TV", 12000m, "LG 32-Inch", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 60.0 },
                    { new Guid("ce86bf01-3875-4dac-8918-d7328d439b2e"), new Guid("8b726886-e719-413c-a125-939ee5af387d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sony 65-Inch 4K Ultra HD Smart LED TV", 10000m, "Sony 65-Inch", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 70.0 },
                    { new Guid("232f28e3-6fad-4ebd-9ea5-6c2ed48bf23e"), new Guid("8b726886-e719-413c-a125-939ee5af387d"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Samsung 32-Inch 1080p Smart LED TV", 15000m, "Samsung 32-Inch", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 50.0 },
                    { new Guid("e0de4e9f-3b88-456c-a364-dd263a3aba84"), new Guid("1236a458-0802-4340-bdd4-05859c9aaaad"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "JBL Tune 500BT On-Ear", 15m, "JBL Tune", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.29999999999999999 },
                    { new Guid("c547f38d-a4e0-4617-adfc-bf95aad7c2df"), new Guid("1236a458-0802-4340-bdd4-05859c9aaaad"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Panasonic ErgoFit In-Ear", 29m, "Panasonic ErgoFit", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.40000000000000002 },
                    { new Guid("ddc4a52b-a9bc-4bf6-be11-699ae206a293"), new Guid("1236a458-0802-4340-bdd4-05859c9aaaad"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Sennheiser CX Wireless In-Ear", 44m, "Sennheiser CX", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 0.40000000000000002 },
                    { new Guid("28084f89-0afa-4b66-8964-12fe25f4b894"), new Guid("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "HP Zbook Laptop", 2000m, "HP Zbook", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 3.0 },
                    { new Guid("234f7621-6348-422d-880a-a601045a0f0a"), new Guid("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "MacBook Laptop", 3000m, "MacBook Pro", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2.1000000000000001 },
                    { new Guid("6e183fc1-c770-4b3b-abde-5f0c1ed5a418"), new Guid("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"), null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Lenovo Thinkpad Laptop", 2800m, "Lenovo Thinkpad", null, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1.7 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_CategoryId",
                table: "Product",
                column: "CategoryId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "ProductCategory");
        }
    }
}
