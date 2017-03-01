namespace FluffyCRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zipcode2 : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.ZipCodes");
            AddColumn("dbo.ZipCodes", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.ZipCodes", "Zip", c => c.String(maxLength: 15));
            AddPrimaryKey("dbo.ZipCodes", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.ZipCodes");
            AlterColumn("dbo.ZipCodes", "Zip", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.ZipCodes", "ID");
            AddPrimaryKey("dbo.ZipCodes", "Zip");
        }
    }
}
