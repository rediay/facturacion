using Microsoft.EntityFrameworkCore.Migrations;

namespace dataAcces.Migrations
{
    public partial class UpdatePropertiesTables : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CantidadPedida",
                table: "BillDetails");

            migrationBuilder.DropColumn(
                name: "idProducto",
                table: "BillDetails");

            migrationBuilder.RenameColumn(
                name: "TotalVenta",
                table: "Bills",
                newName: "FullSale");

            migrationBuilder.RenameColumn(
                name: "idVentas",
                table: "BillDetails",
                newName: "QuantityOrdered");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FullSale",
                table: "Bills",
                newName: "TotalVenta");

            migrationBuilder.RenameColumn(
                name: "QuantityOrdered",
                table: "BillDetails",
                newName: "idVentas");

            migrationBuilder.AddColumn<int>(
                name: "CantidadPedida",
                table: "BillDetails",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "idProducto",
                table: "BillDetails",
                type: "int",
                nullable: true);
        }
    }
}
