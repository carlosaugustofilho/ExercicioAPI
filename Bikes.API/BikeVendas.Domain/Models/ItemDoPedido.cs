using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeVendas.API.BikeVendas.Domain.Models
{
    [Table("ItemDoPedidos")]
    public class ItemDoPedido
    {
        [Key]
        public int PedidoId { get; set; }

        [Required(ErrorMessage = "Informe o Pedido")]
        [Display(Name = "Nome do Pedido")]
        public string? NomePedido { get; set; }

        [Required(ErrorMessage = "Escolha o item ")]
        [Display(Name = "Quantidade Do Valor Em Unidades")]
        [Column(TypeName = "Unidades")]
        [MinLength(1, ErrorMessage = "Escolha Pelo Menos {1} Item Para Fazer o Pedido")]
        [MaxLength(200, ErrorMessage = "Quantide Apenas de {200} itens ")]
        public int? ValorUnitario { get; set; }

        public IEnumerable<Cliente>? Clientes { get; set; }


    }
}
