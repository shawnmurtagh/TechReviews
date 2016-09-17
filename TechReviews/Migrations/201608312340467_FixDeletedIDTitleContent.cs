namespace TechReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixDeletedIDTitleContent : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reviews");
            AddColumn("dbo.Reviews", "ID", c => c.Int(nullable: false, identity: true));
            AddColumn("dbo.Reviews", "Title", c => c.String(nullable: false, maxLength: 25));
            AddColumn("dbo.Reviews", "Content", c => c.String(nullable: false, maxLength: 300));
            AlterColumn("dbo.Reviews", "Author", c => c.String(nullable: false, maxLength: 25));
            AddPrimaryKey("dbo.Reviews", "ID");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Reviews");
            AlterColumn("dbo.Reviews", "Author", c => c.String(nullable: false, maxLength: 128));
            DropColumn("dbo.Reviews", "Content");
            DropColumn("dbo.Reviews", "Title");
            DropColumn("dbo.Reviews", "ID");
            AddPrimaryKey("dbo.Reviews", "Author");
        }
    }
}
