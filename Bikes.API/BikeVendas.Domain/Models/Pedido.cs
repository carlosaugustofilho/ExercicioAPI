using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeVendas.API.BikeVendas.Domain.Models
{
    [Table("Pedidos")]
    public class Pedido
    {
        [Key]
        public int PedidoId { get; set; }

        [Required]
        [Display(Name = "Nome do Pedido")]
        [Column(Order = 1)]
        public int NumeroDoPedido { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormatAttribute(ApplyFormatInEditMode = true, DataFormatString = "{0:d}")]
        public DateTime DataDeCriação { get; set; }

        public List<ItemDoPedido>? ItemDoPedidos { get; set; }
        public bool IsPedidos { get; internal set; }
    }
}
