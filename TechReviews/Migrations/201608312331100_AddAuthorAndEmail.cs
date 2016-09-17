namespace TechReviews.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddAuthorAndEmail : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Reviews");
            AddColumn("dbo.Reviews", "Author", c => c.String(nullable: false, maxLength: 128));
            AddColumn("dbo.Reviews", "Email", c => c.String());
            AddPrimaryKey("dbo.Reviews", "Author");
            DropColumn("dbo.Reviews", "ID");
            DropColumn("dbo.Reviews", "Title");
            DropColumn("dbo.Reviews", "Content");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Reviews", "Content", c => c.String());
            AddColumn("dbo.Reviews", "Title", c => c.String());
            AddColumn("dbo.Reviews", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Reviews");
            DropColumn("dbo.Reviews", "Email");
            DropColumn("dbo.Reviews", "Author");
            AddPrimaryKey("dbo.Reviews", "ID");
        }
    }
}
