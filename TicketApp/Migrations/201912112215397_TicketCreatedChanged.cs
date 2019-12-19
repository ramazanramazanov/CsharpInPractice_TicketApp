namespace TicketSystemApp.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TicketCreatedChanged : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tickets", "ClosedBy", "dbo.Users");
            DropIndex("dbo.Tickets", new[] { "ClosedBy" });
            AlterColumn("dbo.Tickets", "ClosedDate", c => c.DateTime());
            AlterColumn("dbo.Tickets", "ClosedBy", c => c.Int());
            CreateIndex("dbo.Tickets", "ClosedBy");
            AddForeignKey("dbo.Tickets", "ClosedBy", "dbo.Users", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tickets", "ClosedBy", "dbo.Users");
            DropIndex("dbo.Tickets", new[] { "ClosedBy" });
            AlterColumn("dbo.Tickets", "ClosedBy", c => c.Int(nullable: false));
            AlterColumn("dbo.Tickets", "ClosedDate", c => c.DateTime(nullable: false));
            CreateIndex("dbo.Tickets", "ClosedBy");
            AddForeignKey("dbo.Tickets", "ClosedBy", "dbo.Users", "Id", cascadeDelete: true);
        }
    }
}
