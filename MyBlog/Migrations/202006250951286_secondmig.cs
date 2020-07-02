namespace MyBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmig : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Expiriences", "Class");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Expiriences", "Class", c => c.String(nullable: false, maxLength: 100));
        }
    }
}
