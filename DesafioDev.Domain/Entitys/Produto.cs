using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DesafioDev.Domain.Entitys
{
    public class Produto
    {
        [Key]
        public int pro_codigo { get; private set; }
        [Required]
        [StringLength(100)]
        public string pro_nome { get; private set; }
        [Required]
        [DefaultValue(true)]
        public bool pro_situacao { get; private set; }
        public DateTime pro_datafabricacao { get; private set; }
        public DateTime pro_datavalidade { get; private set; }
        [ForeignKey("Fornecedor")]
        public int for_codigo { get; private set; }

        public Produto(int pro_codigo, string pro_nome, bool pro_situacao, DateTime pro_datafabricacao, DateTime pro_datavalidade, int for_codigo)
        {
            ValidaDataFabricacao(pro_datafabricacao, pro_datavalidade);
            this.pro_codigo = pro_codigo;
            this.pro_nome = pro_nome;
            this.pro_situacao = pro_situacao;
            this.pro_datafabricacao = pro_datafabricacao;
            this.pro_datavalidade = pro_datavalidade;
            this.for_codigo = for_codigo;
        }

        public void Update(DateTime pro_datafabricacao, DateTime pro_datavalidade)
        {
            ValidaDataFabricacao(pro_datafabricacao, pro_datavalidade);
        }

        private void ValidaDataFabricacao(DateTime pro_datafabricacao, DateTime pro_datavalidade)
        {
            if (pro_datafabricacao >= pro_datavalidade)
            {
                throw new InvalidOperationException("A Data de Fabricação não pode ser maior ou igual a Data de Validade.");
            }                
        }
    }
}