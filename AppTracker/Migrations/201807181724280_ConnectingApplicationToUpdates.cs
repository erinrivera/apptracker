namespace AppTracker.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ConnectingApplicationToUpdates : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Update", "ApplicationID", "dbo.Application");
            DropPrimaryKey("dbo.Application");
            DropColumn("dbo.Application", "ApplicationID");
            AddColumn("dbo.Application", "ID", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Application", "ID");
            AddForeignKey("dbo.Update", "ApplicationID", "dbo.Application", "ID", cascadeDelete: true);
            
        }
        
        public override void Down()
        {
            AddColumn("dbo.Application", "ApplicationID", c => c.Int(nullable: false, identity: true));
            DropForeignKey("dbo.Update", "ApplicationID", "dbo.Application");
            DropPrimaryKey("dbo.Application");
            DropColumn("dbo.Application", "ID");
            AddPrimaryKey("dbo.Application", "ApplicationID");
            AddForeignKey("dbo.Update", "ApplicationID", "dbo.Application", "ApplicationID", cascadeDelete: true);
        }
    }
}