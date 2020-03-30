namespace MyBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class MigrateDB : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Contact_Details",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Class = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.id);
            
            CreateTable(
                "dbo.ProjectSClientsSes",
                c => new
                    {
                        id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Value = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.id);
            
            AddColumn("dbo.Contacts", "Source", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.Contacts", "Class", c => c.String(nullable: false, maxLength: 100));
            AddColumn("dbo.WHAT_CAN__I_DO", "Class", c => c.String(nullable: false, maxLength: 100));
        }
        
        public override void Down()
        {
            DropColumn("dbo.WHAT_CAN__I_DO", "Class");
            DropColumn("dbo.Contacts", "Class");
            DropColumn("dbo.Contacts", "Source");
            DropTable("dbo.ProjectSClientsSes");
            DropTable("dbo.Contact_Details");
        }
    }
}
