using Microsoft.EntityFrameworkCore.Migrations;

namespace DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "79af36b7-e7cb-44c4-871c-fd1fdda2cea7");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d0c16942-bb6f-4695-b13a-31503c9f6b19");

            migrationBuilder.DropColumn(
                name: "WherehouseId",
                table: "Storages");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CategoryId", "ProductDescription", "ProductName", "TotalQuantity" },
                values: new object[,]
                {
                    { "ASJ-98745", "PRF", "", "Crema para manos marca Tersa", 0 },
                    { "RPT-5465879", "SLD", "", "Pastillas para la garganta LESUS", 0 }
                });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[,]
                {
                    { "b9b67efb-b314-4706-ab2a-9032f1f8513e", "Calle 8 con 23", "Bodega Central" },
                    { "d3a80fe2-255c-4dfb-872f-082bca66034b", "Calle norte con occidente", "Bodega Norte" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "ASJ-98745");

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: "RPT-5465879");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "b9b67efb-b314-4706-ab2a-9032f1f8513e");

            migrationBuilder.DeleteData(
                table: "Warehouses",
                keyColumn: "WarehouseId",
                keyValue: "d3a80fe2-255c-4dfb-872f-082bca66034b");

            migrationBuilder.AddColumn<string>(
                name: "WherehouseId",
                table: "Storages",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "79af36b7-e7cb-44c4-871c-fd1fdda2cea7", "Calle 8 con 23", "Bodega Central" });

            migrationBuilder.InsertData(
                table: "Warehouses",
                columns: new[] { "WarehouseId", "WarehouseAddress", "WarehouseName" },
                values: new object[] { "d0c16942-bb6f-4695-b13a-31503c9f6b19", "Calle norte con occidente", "Bodega Norte" });
        }
    }
}
