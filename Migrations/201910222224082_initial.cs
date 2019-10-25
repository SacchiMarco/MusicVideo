namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Kategoriens",
                c => new
                    {
                        a_id = c.Int(nullable: false),
                        a_name = c.String(),
                    })
                .PrimaryKey(t => t.a_id);
            
            CreateTable(
                "dbo.Videos",
                c => new
                    {
                        v_id = c.Int(nullable: false, identity: true),
                        titel = c.String(maxLength: 255, unicode: false),
                        dateigroesse = c.Int(nullable: false),
                        qualitaet = c.Int(nullable: false),
                        fk_a_id = c.Int(nullable: false),
                        anmerkung = c.String(maxLength: 255, unicode: false),
                        benotung = c.Int(nullable: false),
                        erscheinungsjahr = c.Int(nullable: false),
                        album = c.String(),
                        fk_k_id = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.v_id)
                .ForeignKey("dbo.Kategoriens", t => t.fk_a_id, cascadeDelete: true)
                .ForeignKey("dbo.Kuenstlers", t => t.fk_k_id, cascadeDelete: true)
                .Index(t => t.fk_a_id)
                .Index(t => t.fk_k_id);
            
            CreateTable(
                "dbo.Kuenstlers",
                c => new
                    {
                        k_id = c.Int(nullable: false),
                        k_name = c.String(),
                    })
                .PrimaryKey(t => t.k_id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Videos", "fk_k_id", "dbo.Kuenstlers");
            DropForeignKey("dbo.Videos", "fk_a_id", "dbo.Kategoriens");
            DropIndex("dbo.Videos", new[] { "fk_k_id" });
            DropIndex("dbo.Videos", new[] { "fk_a_id" });
            DropTable("dbo.Kuenstlers");
            DropTable("dbo.Videos");
            DropTable("dbo.Kategoriens");
        }
    }
}
