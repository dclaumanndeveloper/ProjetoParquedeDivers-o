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
        public String nome{get;set;}
        [Display(Name="Manutenção")]
        public String manutencao{get;set;}
        [Display(Name="Ultima Manutenção")]
        public DateTime ultimaManutencao { get; set; }
        [Display(Name ="Parque")]
        public virtual Parque parque { get; set; }
        public int parqueId { get; set; }
    }
}