using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace miniPrpject_Asp.Models
{
    public class Cours
    {
        public int Id { get; set; }
        public string Nom { get; set; }

        public string Groupe { get; set; }

        

        public virtual ICollection<DetailEmploi> LDE { get; set; }

        [ForeignKey("Professeur")]

        public int IdProf { get; set; }
        public virtual Professeur Professeur { get; set; }

        [ForeignKey("Classe")]
        public int IdNiveau { get; set; }
        public virtual Classe Classe { get; set; }


    }
}