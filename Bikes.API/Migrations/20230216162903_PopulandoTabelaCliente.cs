using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bikes.API.Migrations
{
    public partial class PopulandoTabelaCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("INSERT INTO CLIENTES(Nome, Email) " +
                "VALUES('Fernanda', 'fernandasouza@gmail.com')");

            migrationBuilder.Sql("INSERT INTO CLIENTES(Nome, Email) " +
                "VALUES('Fernanda', 'fernandasouza@gmail.com')");
        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DELETE FROM Clientes");
        }
    }
}
