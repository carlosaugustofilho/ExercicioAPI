using BikeVendas.API.BikeVendas.Domain.Models;

namespace Bikes.API.BikeVendas.DBExtension.Repositories.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> Clientes { get; }
    }
}
