using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bikes.API.Migrations
{
    public partial class PopulandoTabelaItemPedido : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "ItemDoPedidos");

            migrationBuilder.DropColumn(
                name: "Nome",
                table: "ItemDoPedidos");

            migrationBuilder.AddColumn<bool>(
                name: "IsPedidos",
                table: "Pedidos",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "ItemDoPedidoPedidoId",
                table: "Clientes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Clientes_ItemDoPedidoPedidoId",
                table: "Clientes",
                column: "ItemDoPedidoPedidoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Clientes_ItemDoPedidos_ItemDoPedidoPedidoId",
                table: "Clientes",
                column: "ItemDoPedidoPedidoId",
                principalTable: "ItemDoPedidos",
                principalColumn: "PedidoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Clientes_ItemDoPedidos_ItemDoPedidoPedidoId",
                table: "Clientes");

            migrationBuilder.DropIndex(
                name: "IX_Clientes_ItemDoPedidoPedidoId",
                table: "Clientes");

            migrationBuilder.DropColumn(
                name: "IsPedidos",
                table: "Pedidos");

            migrationBuilder.DropColumn(
                name: "ItemDoPedidoPedidoId",
                table: "Clientes");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "ItemDoPedidos",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Nome",
                table: "ItemDoPedidos",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
