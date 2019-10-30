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
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 10, 30, 22, 58, 59, 253, DateTimeKind.Local).AddTicks(537)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "skose"),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
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
                    CreatedDate = table.Column<DateTime>(nullable: false, defaultValue: new DateTime(2019, 10, 30, 22, 58, 59, 249, DateTimeKind.Local).AddTicks(675)),
                    CreatedBy = table.Column<string>(nullable: true, defaultValue: "skose"),
                    UpdatedDate = table.Column<DateTime>(nullable: true),
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
                columns: new[] { "Id", "CategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("8b726886-e719-413c-a125-939ee5af387d"), "TV", null, null });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("1236a458-0802-4340-bdd4-05859c9aaaad"), "Headphones", null, null });

            migrationBuilder.InsertData(
                table: "ProductCategory",
                columns: new[] { "Id", "CategoryName", "UpdatedBy", "UpdatedDate" },
                values: new object[] { new Guid("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"), "Computers", null, null });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[] { new Guid("2f2aed89-f417-4225-822a-113baf3041f5"), new Guid("8b726886-e719-413c-a125-939ee5af387d"), "LG 32-Inch 720p LED TV", 12000m, "LG 32-Inch", null, null, 60.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[] { new Guid("570b67c6-7a24-4041-8582-0ceba4debf0b"), new Guid("8b726886-e719-413c-a125-939ee5af387d"), "Sony 65-Inch 4K Ultra HD Smart LED TV", 10000m, "Sony 65-Inch", null, null, 70.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[] { new Guid("5d54be88-12fa-4ccf-b394-c8d909111449"), new Guid("8b726886-e719-413c-a125-939ee5af387d"), "Samsung 32-Inch 1080p Smart LED TV", 15000m, "Samsung 32-Inch", null, null, 50.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[] { new Guid("746e00e0-49dc-42a8-b935-96697f772478"), new Guid("1236a458-0802-4340-bdd4-05859c9aaaad"), "JBL Tune 500BT On-Ear", 15m, "JBL Tune", null, null, 0.29999999999999999 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[] { new Guid("218a34f5-52a0-4106-9c98-ba3acdf3db6f"), new Guid("1236a458-0802-4340-bdd4-05859c9aaaad"), "Panasonic ErgoFit In-Ear", 29m, "Panasonic ErgoFit", null, null, 0.40000000000000002 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[] { new Guid("390ab7d0-3d23-456b-854c-0e5b153b08fa"), new Guid("1236a458-0802-4340-bdd4-05859c9aaaad"), "Sennheiser CX Wireless In-Ear", 44m, "Sennheiser CX", null, null, 0.40000000000000002 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[] { new Guid("bc4987fe-1226-419c-b140-cf6327542b32"), new Guid("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"), "HP Zbook Laptop", 2000m, "HP Zbook", null, null, 3.0 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[] { new Guid("0ffd7b32-0df0-40c0-9905-6ad65ae11433"), new Guid("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"), "MacBook Laptop", 3000m, "MacBook Pro", null, null, 2.1000000000000001 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "CategoryId", "Description", "Price", "ProductName", "UpdatedBy", "UpdatedDate", "Weight" },
                values: new object[] { new Guid("baaeab63-7bab-467c-a06f-274eedea528a"), new Guid("a65bc1ae-c1c7-4c20-8b3b-4b48490d3fb0"), "Lenovo Thinkpad Laptop", 2800m, "Lenovo Thinkpad", null, null, 1.7 });

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
