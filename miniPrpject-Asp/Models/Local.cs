using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace miniPrpject_Asp.Models
{
    public class Local
    {
        public int Id { get; set; }
        public string TypeLocal { get; set; }
        public int Capacite { get; set; }
        public string Nom { get; set; }
        public string localisation { get; set; }

        public virtual ICollection<DetailEmploi> ListeDE { get; set; }

         
    }
}