using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace dev_Junior.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Display(Name="Código")]
        [Column("Id")]
        public int Id {get; set;}

        [Display(Name = "Nome")]
        [Column("Nome")]
        public string Nome {get; set;}
    }
}
