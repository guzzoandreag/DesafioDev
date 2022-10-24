using System.ComponentModel.DataAnnotations;

namespace DesafioDev.Domain.Entitys
{
    public class Fornecedor
    {
        [Key]
        public int for_codigo { get; set; }
        [Required]
        [StringLength(100)]
        public string for_nome { get; set; }
        [Required]
        [StringLength(14)]
        public string for_cnpj { get; set; }
    }
}