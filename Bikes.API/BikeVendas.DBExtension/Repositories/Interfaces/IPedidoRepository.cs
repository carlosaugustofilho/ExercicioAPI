using BikeVendas.API.BikeVendas.Domain.Models;

namespace Bikes.API.BikeVendas.DBExtension.Repositories.Interfaces
{
    public interface IPedidoRepository
    {
        IEnumerable<Pedido> Pedidos { get; }

        IEnumerable<Pedido> NumeroDoPedido { get; }

        Pedido GetPedidoById(int PedidoId);
    }
}
