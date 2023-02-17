using BikeVendas.API.BikeVendas.DBExtension;
using BikeVendas.API.BikeVendas.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeVendas.API.Bikes.Api.Controllers
{
    public class ItemDoPedidoController
    {
        [ApiController]
        [Route("Pedido[controller]")]
        public class UsuarioCrontoller : ControllerBase
        {
            private readonly VendasBikeDbContext context;

            public UsuarioCrontoller(VendasBikeDbContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public IEnumerable<ItemDoPedido> Get()
            {
                return (IEnumerable<ItemDoPedido>)context.itemDoPedidos;
            }
            [HttpGet("id")]
            public IEnumerable<ItemDoPedido> BuscarPorId(int id)
            {
                return (IEnumerable<ItemDoPedido>)context.itemDoPedidos;
            }

            [HttpGet]
            public IEnumerable<ItemDoPedido> ListarTodos()
            {
                return (IEnumerable<ItemDoPedido>)context.itemDoPedidos;
            }
            [HttpPost]
            public IEnumerable<ItemDoPedido> Post()
            {
                return (IEnumerable<ItemDoPedido>)context.itemDoPedidos;
            }
            [HttpPut("{id}")]
            public IEnumerable<ItemDoPedido> PutPorId(int id)
            {
                return (IEnumerable<ItemDoPedido>)context.itemDoPedidos;
            }
            [HttpDelete("{id}")]
            public IEnumerable<ItemDoPedido> DeletarPorId(int id)
            {
                return (IEnumerable<ItemDoPedido>)context.itemDoPedidos;
            }
        }
    }
}
