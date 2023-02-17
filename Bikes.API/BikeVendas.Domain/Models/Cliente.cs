using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BikeVendas.API.BikeVendas.Domain.Models
{
    [Table("Clientes")]
    public class Cliente
    {
        [Key]
        public int ClienteId { get; set; }

        [StringLength(50, ErrorMessage = "O Tamnaho máximo é 50 caracteres")]
        [Required(ErrorMessage = "Informe o Nome")]
        [Display(Name = "Nome")]
        public string? Nome { get; set; }

        [StringLength(50, ErrorMessage = "O Tamnaho máximo é 100 caracteres")]
        [Required(ErrorMessage = "Informe o Email")]
        [Display(Name = "Email")]
        public string? Email { get; set; }

        public IEnumerable<Pedido> Pedidos { get; set; }
    }
}
