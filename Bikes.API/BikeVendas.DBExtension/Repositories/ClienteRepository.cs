using Bikes.API.BikeVendas.DBExtension.Repositories.Interfaces;
using BikeVendas.API.BikeVendas.DBExtension;
using BikeVendas.API.BikeVendas.Domain.Models;

namespace Bikes.API.BikeVendas.DBExtension.Repositories
{
    public class ClienteRepository : IClienteRepository
    {
        private readonly VendasBikeDbContext _context;

        public ClienteRepository(VendasBikeDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Cliente> Clientes => _context.Clientes;
    }
}
