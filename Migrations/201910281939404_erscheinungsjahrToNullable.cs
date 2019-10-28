namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class erscheinungsjahrToNullable : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Videos", "titel", c => c.String(nullable: false, maxLength: 255, unicode: false));
            AlterColumn("dbo.Videos", "erscheinungsjahr", c => c.Int());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Videos", "erscheinungsjahr", c => c.Int(nullable: false));
            AlterColumn("dbo.Videos", "titel", c => c.String(maxLength: 255, unicode: false));
        }
    }
}
