using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bikes.API.Migrations
{
    public partial class PopulandoTabelaPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CLIENTES(NumeroDoPedido, DataDeCriação) " +
                "VALUES('01', '16/02/2023')");
            migrationBuilder.Sql("INSERT INTO CLIENTES(NumeroDoPedido, DataDeCriação) " +
                "VALUES('02', '16/02/2023')");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE Pedidos");
        }
    }
}
