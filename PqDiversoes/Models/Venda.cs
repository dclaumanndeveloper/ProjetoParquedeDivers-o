using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace PqDiversoes.Models
{
    public class Venda
    {
        [Key]
        private int id { get; set; }
        public string descricao { get; set; }
        public float preco { get; set; }
        public string tipoVenda { get; set; }
        public DateTime validade { get; set; }
        public List<Brinquedo> brinquedos { get; set; }


    }
}