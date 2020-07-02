namespace MyBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmig1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Expiriences", "Text", c => c.String(nullable: false, maxLength: 200));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Expiriences", "Text");
        }
    }
}
