namespace miniPrpject_Asp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Admins",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Annees",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        StartDate = c.String(),
                        StartEnd = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Emplois",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        startDate = c.String(),
                        startEnd = c.String(),
                        IdSemaine = c.Int(nullable: false),
                        IdAnnee = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Annees", t => t.IdAnnee, cascadeDelete: true)
                .ForeignKey("dbo.Semaines", t => t.IdSemaine, cascadeDelete: true)
                .Index(t => t.IdSemaine)
                .Index(t => t.IdAnnee);
            
            CreateTable(
                "dbo.DetailEmplois",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        IdEmploi = c.Int(nullable: false),
                        IdSeance = c.Int(nullable: false),
                        IdLocal = c.Int(nullable: false),
                        IdCours = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cours", t => t.IdCours, cascadeDelete: true)
                .ForeignKey("dbo.Emplois", t => t.IdEmploi, cascadeDelete: true)
                .ForeignKey("dbo.Locals", t => t.IdLocal, cascadeDelete: true)
                .ForeignKey("dbo.Seances", t => t.IdSeance, cascadeDelete: true)
                .Index(t => t.IdEmploi)
                .Index(t => t.IdSeance)
                .Index(t => t.IdLocal)
                .Index(t => t.IdCours);
            
            CreateTable(
                "dbo.Cours",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Groupe = c.String(),
                        IdProf = c.Int(nullable: false),
                        IdNiveau = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classes", t => t.IdNiveau, cascadeDelete: true)
                .ForeignKey("dbo.Professeurs", t => t.IdProf, cascadeDelete: true)
                .Index(t => t.IdProf)
                .Index(t => t.IdNiveau);
            
            CreateTable(
                "dbo.Classes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomClasse = c.String(),
                        code = c.String(),
                        IdFiliere = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Filieres", t => t.IdFiliere, cascadeDelete: true)
                .Index(t => t.IdFiliere);
            
            CreateTable(
                "dbo.Filieres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Professeurs",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nom = c.String(),
                        Prenom = c.String(),
                        UserName = c.String(),
                        Password = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Locals",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeLocal = c.String(),
                        Capacite = c.Int(nullable: false),
                        Nom = c.String(),
                        localisation = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Seances",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        HeurDebut = c.String(),
                        HeurFin = c.String(),
                        jour = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Semaines",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        NomSemaine = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Emplois", "IdSemaine", "dbo.Semaines");
            DropForeignKey("dbo.DetailEmplois", "IdSeance", "dbo.Seances");
            DropForeignKey("dbo.DetailEmplois", "IdLocal", "dbo.Locals");
            DropForeignKey("dbo.DetailEmplois", "IdEmploi", "dbo.Emplois");
            DropForeignKey("dbo.DetailEmplois", "IdCours", "dbo.Cours");
            DropForeignKey("dbo.Cours", "IdProf", "dbo.Professeurs");
            DropForeignKey("dbo.Cours", "IdNiveau", "dbo.Classes");
            DropForeignKey("dbo.Classes", "IdFiliere", "dbo.Filieres");
            DropForeignKey("dbo.Emplois", "IdAnnee", "dbo.Annees");
            DropIndex("dbo.Classes", new[] { "IdFiliere" });
            DropIndex("dbo.Cours", new[] { "IdNiveau" });
            DropIndex("dbo.Cours", new[] { "IdProf" });
            DropIndex("dbo.DetailEmplois", new[] { "IdCours" });
            DropIndex("dbo.DetailEmplois", new[] { "IdLocal" });
            DropIndex("dbo.DetailEmplois", new[] { "IdSeance" });
            DropIndex("dbo.DetailEmplois", new[] { "IdEmploi" });
            DropIndex("dbo.Emplois", new[] { "IdAnnee" });
            DropIndex("dbo.Emplois", new[] { "IdSemaine" });
            DropTable("dbo.Semaines");
            DropTable("dbo.Seances");
            DropTable("dbo.Locals");
            DropTable("dbo.Professeurs");
            DropTable("dbo.Filieres");
            DropTable("dbo.Classes");
            DropTable("dbo.Cours");
            DropTable("dbo.DetailEmplois");
            DropTable("dbo.Emplois");
            DropTable("dbo.Annees");
            DropTable("dbo.Admins");
        }
    }
}
