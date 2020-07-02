namespace MyBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmig2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expiriences", "Company", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Expiriences", "Company");
        }
    }
}
