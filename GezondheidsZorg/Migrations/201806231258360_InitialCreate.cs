namespace GezondheidsZorg.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Arts",
                c => new
                    {
                        ArtsID = c.Int(nullable: false, identity: true),
                        Voornaam = c.String(),
                        Achternaam = c.String(),
                        Adres = c.String(),
                        Postcode = c.String(),
                        Einddatum = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.ArtsID);
            
            CreateTable(
                "dbo.Klants",
                c => new
                    {
                        KlantID = c.Int(nullable: false, identity: true),
                        Voornaam = c.String(),
                        Achternaam = c.String(),
                        Adres = c.String(),
                        Postcode = c.String(),
                    })
                .PrimaryKey(t => t.KlantID);
            
            CreateTable(
                "dbo.Medicaties",
                c => new
                    {
                        MedicatieID = c.Int(nullable: false, identity: true),
                        MedicatieNaam = c.String(),
                        KlantID = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.MedicatieID)
                .ForeignKey("dbo.Klants", t => t.KlantID, cascadeDelete: true)
                .Index(t => t.KlantID);
            
            CreateTable(
                "dbo.Verzekerings",
                c => new
                    {
                        VerzekeringID = c.Int(nullable: false, identity: true),
                        VerzekeringNaam = c.String(),
                    })
                .PrimaryKey(t => t.VerzekeringID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Medicaties", "KlantID", "dbo.Klants");
            DropIndex("dbo.Medicaties", new[] { "KlantID" });
            DropTable("dbo.Verzekerings");
            DropTable("dbo.Medicaties");
            DropTable("dbo.Klants");
            DropTable("dbo.Arts");
        }
    }
}
