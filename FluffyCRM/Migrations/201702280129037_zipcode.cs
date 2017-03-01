namespace FluffyCRM.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class zipcode : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ZipCodes",
                c => new
                    {
                        Zip = c.String(nullable: false, maxLength: 128),
                        City = c.String(maxLength: 50),
                        StateAbbrev = c.String(maxLength: 5),
                    })
                .PrimaryKey(t => t.Zip);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ZipCodes");
        }
    }
}
