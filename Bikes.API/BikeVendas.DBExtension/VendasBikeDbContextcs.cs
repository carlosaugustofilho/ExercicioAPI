using BikeVendas.API.BikeVendas.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace BikeVendas.API.BikeVendas.DBExtension
{
    public class VendasBikeDbContext : DbContext
    {
        public VendasBikeDbContext(DbContextOptions<VendasBikeDbContext> options) : base(options)
        {

        }
        public DbSet<Cliente> Clientes { get; set; }

        public DbSet<ItemDoPedido> itemDoPedidos { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }
    }
}
