namespace CodeFirst.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Try3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Accounts", "Name", c => c.String());
            AddColumn("dbo.Accounts", "Type", c => c.String());
            AddColumn("dbo.Accounts", "Active", c => c.Boolean(nullable: false));
            DropColumn("dbo.Accounts", "UserName");
            DropColumn("dbo.Accounts", "Address");
            DropColumn("dbo.Accounts", "Online");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Accounts", "Online", c => c.Boolean(nullable: false));
            AddColumn("dbo.Accounts", "Address", c => c.String());
            AddColumn("dbo.Accounts", "UserName", c => c.String());
            DropColumn("dbo.Accounts", "Active");
            DropColumn("dbo.Accounts", "Type");
            DropColumn("dbo.Accounts", "Name");
        }
    }
}
