using Bikes.API.BikeVendas.DBExtension.Repositories.Interfaces;
using BikeVendas.API.BikeVendas.DBExtension;
using BikeVendas.API.BikeVendas.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace Bikes.API.BikeVendas.DBExtension.Repositories
{
    public class PedidoRepository : IPedidoRepository
    {
        private readonly VendasBikeDbContext _context;

        public PedidoRepository(VendasBikeDbContext context) 
        {
        
            _context = context;
        }

        public IEnumerable<Pedido> Pedidos => _context.Pedidos.Include(c => c.PedidoId);

        public IEnumerable<Pedido> NumeroDoPedido => _context.Pedidos
                                                                     .Where(p => p.IsPedidos)
                                                                     .Include(c => c.NumeroDoPedido);

        public Pedido GetPedidoById(int PedidoId)
        {
            return _context.Pedidos.FirstOrDefault(p => p.PedidoId == PedidoId);
        }
    }
}
