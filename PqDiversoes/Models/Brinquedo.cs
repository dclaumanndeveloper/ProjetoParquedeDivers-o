using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel;



namespace PqDiversoes.Models
{
    public class Brinquedo
    {
        [Key]
        public int ID{get;set;}
        [Display(Name="Brinquedo")]
        public String Nome{get;set;}
        [Display(Name="Manuten��o")]
        public DateTime Manutencao{get;set;}
        [Display(Name="Ultima Manuten��o")]
        public DateTime UltimaManutencao{get;}
    }
}