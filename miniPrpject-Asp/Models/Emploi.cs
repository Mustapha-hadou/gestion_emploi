using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace miniPrpject_Asp.Models
{
    public class Emploi
    {
        public int id_niveau { get; set; }
        public int Id { get; set; }
        public string startDate { get; set; }
        public string startEnd { get; set; }
        public virtual ICollection<DetailEmploi> LDE { get; set; }

        [ForeignKey("Semaine")]

        public int IdSemaine { get; set; }
        public virtual Semaine Semaine { get; set; }

        [ForeignKey("Annee")]

        public int IdAnnee { get; set; }
        public virtual Annee Annee { get; set; }
       
       
    }
}