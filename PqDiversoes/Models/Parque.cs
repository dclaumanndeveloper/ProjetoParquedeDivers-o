using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;

namespace PqDiversoes.Models
{
    public class Parque
    {
        [Key]
        public int ID { get; set; }
        [Display(Name = "Parque")]
        public String nomeFantasia { get; set; }
        [Display(Name = "Razão Social")]
        public String razaoSocial { get; set; }
        [Display(Name = "CNPJ")]
        public String cnpj { get; set; }
        [Display(Name = "Quantidade de Brinquedos")]
        public int qtdBrinquedos { get; set; }

    }


}

