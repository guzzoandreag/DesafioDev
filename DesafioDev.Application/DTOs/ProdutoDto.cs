using System;

namespace DesafioDev.Application.DTOs
{
    public class ProdutoDto
    {
        public int pro_codigo { get; set; }
        public string pro_nome { get; set; }
        public bool pro_situacao { get; set; }
        public DateTime pro_datafabricacao { get; set; }
        public DateTime pro_datavalidade { get; set; }
        public int for_codigo { get; set; }
    }
}