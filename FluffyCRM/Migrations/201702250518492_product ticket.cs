namespace FluffyCRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class productticket : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Products",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 255),
                        Description = c.String(),
                        CreateDate = c.DateTime(nullable: false),
                        CurrentVersion = c.String(maxLength: 32),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Tickets",
                c => new
                    {
                        TicketId = c.Int(nullable: false, identity: true),
                        Subject = c.String(maxLength: 255),
                        CategoryId = c.Int(nullable: false),
                        CreateDate = c.DateTime(nullable: false),
                        Description = c.String(),
                        Status = c.Int(nullable: false),
                        DeleteInd = c.Boolean(nullable: false),
                        ClientId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        CompletedDate = c.DateTime(nullable: false),
                        DueDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.TicketId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Tickets");
            DropTable("dbo.Products");
        }
    }
}
