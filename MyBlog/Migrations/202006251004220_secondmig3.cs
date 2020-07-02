namespace MyBlog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class secondmig3 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Expiriences", "Text", c => c.String(nullable: false, maxLength: 500));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Expiriences", "Text", c => c.String(nullable: false, maxLength: 200));
        }
    }
}
