using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace miniPrpject_Asp.Models
{
    public class Classe
    {
        public int Id { get; set; }
        public string NomClasse { get; set; }

        public string code { get; set; }
        
        [ForeignKey("Filiere")]

        public int IdFiliere { get; set; }
        public virtual Filiere Filiere { get; set; }
        
       

          }
}