using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace miniPrpject_Asp.Models
{
    public class DetailEmploi
    {
        public int Id { get; set; }

        [ForeignKey("Emploi")]

        public int IdEmploi { get; set; }
        public virtual Emploi Emploi { get; set; }

        [ForeignKey("Seance")]

        public int IdSeance { get; set; }
        public virtual Seance Seance { get; set; }


        [ForeignKey("Local")]

        public int IdLocal { get; set; }
        public virtual Local Local { get; set; }

        [ForeignKey("Cours")]

        public int IdCours{ get; set; }
        public virtual Cours Cours { get; set; }

      

      
    }
}