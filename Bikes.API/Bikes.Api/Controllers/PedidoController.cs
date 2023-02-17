using BikeVendas.API.BikeVendas.DBExtension;
using BikeVendas.API.BikeVendas.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeVendas.API.Bikes.Api.Controllers
{
    public class PedidoController
    {
        [ApiController]
        [Route("ItemDoPedido[controller]")]
        public class UsuarioCrontoller : ControllerBase
        {
            private readonly VendasBikeDbContext context;

            public UsuarioCrontoller(VendasBikeDbContext context)
            {
                this.context = context;
            }

            [HttpGet]
            public IEnumerable<Pedido> Get()
            {
                return (IEnumerable<Pedido>)context.Pedidos;
            }
            [HttpGet("id")]
            public IEnumerable<Pedido> BuscarPorId(int id)
            {
                return (IEnumerable<Pedido>)context.Pedidos;
            }

            [HttpGet]
            public IEnumerable<Pedido> ListarTodos()
            {
                return (IEnumerable<Pedido>)context.Pedidos;
            }
            [HttpPost]
            public IEnumerable<Pedido> Post()
            {
                return (IEnumerable<Pedido>)context.Pedidos;
            }
            [HttpPut("{id}")]
            public IEnumerable<Pedido> PutPorId(int id)
            {
                return (IEnumerable<Pedido>)context.Pedidos;
            }
            [HttpDelete("{id}")]
            public IEnumerable<Pedido> DeletarPorId(int id)
            {
                return (IEnumerable<Pedido>)context.Pedidos;
            }
        }
    }
}
