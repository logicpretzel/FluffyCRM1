namespace FluffyCRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zipcode3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.ZipCodes", "PostalOrder", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.ZipCodes", "PostalOrder");
        }
    }
}
