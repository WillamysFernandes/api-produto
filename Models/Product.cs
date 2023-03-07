using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace APIProduct.Models
{

    public class Product
    {
        [Key]
        public int Id_Produto { get; set; }
        [Required]
        [StringLength(255)]
        public string? Nome_Produto { get; set; }
        [Required]
        [MaxLength(3)]
        public string? Unidade_Medida { get; set; }
        [StringLength(255)]
        public string? Foto_Produto { get; set; }
        [ForeignKey("Id_Tipo_Produto")]
        public int Id_Tipo_Produto { get; set; }
    }
}