
using BikeVendas.API;
using BikeVendas.API.BikeVendas.DBExtension;
using BikeVendas.API.BikeVendas.Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BikeVendas.API.Bikes.Api.Controllers
{
    [ApiController]
    [Route("ClienteApi[controller]")]
    public class UsuarioCrontoller : ControllerBase
    {
        private readonly VendasBikeDbContext context;

        public UsuarioCrontoller(VendasBikeDbContext context)
        {
            this.context = context;
        }

        [HttpGet]
        public IEnumerable<Cliente> Get()
        {
            return (IEnumerable<Cliente>)context.Clientes;
        }
        [HttpGet("id")]
        public IEnumerable<Cliente> BuscarPorId(int id)
        {
            return (IEnumerable<Cliente>)context.Clientes;
        }

        [HttpGet]
        public IEnumerable<Cliente> ListarTodos()
        {
            return (IEnumerable<Cliente>) context.Clientes;
        }
        [HttpPost]
        public IEnumerable<Cliente> Post()
        {
            return (IEnumerable<Cliente>)context.Clientes;
        }
        [HttpPut("{id}")]
        public IEnumerable<Cliente> PutPorId(int id)
        {
            return (IEnumerable<Cliente>)context.Clientes;
        }
        [HttpDelete("{id}")]
        public IEnumerable<Cliente> DeletarPorId(int id)
        {
            return (IEnumerable<Cliente>)context.Clientes;
        }

    }
}