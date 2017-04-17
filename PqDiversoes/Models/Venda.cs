using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PqDiversoes.Models
{
    public class Venda
    {
        private int id { get; set; }
        public string descricao { get; set; }
        public float preco { get; set; }
        public string tipoVenda { get; set; }
        public DateTime validade { get; set; }

    }
}