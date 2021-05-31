using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace miniPrpject_Asp.Models.Data
{
    public class EmploiContext : DbContext
    {
        public EmploiContext(): base("DefaultContext") { }
        public DbSet<Admin> Admins { get; set; }
        public DbSet<Classe> Classes { get; set; }
        public DbSet<Cours> Cours { get; set; }

          public DbSet<DetailEmploi> DetailEmplois { get; set; }

        public DbSet<Emploi> Emplois { get; set; }

        public DbSet<Filiere> Filieres { get; set; }

        public DbSet<Local> Locals { get; set; }
        public DbSet<Professeur> Professeurs { get; set; }

        public DbSet<Annee> Annees { get; set; }

        public DbSet<Seance> Seances { get; set; }

        public DbSet<Semaine> Semaines { get; set; }











    }
}