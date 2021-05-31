namespace miniPrpject_Asp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Emplois", "id_niveau", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Emplois", "id_niveau");
        }
    }
}
