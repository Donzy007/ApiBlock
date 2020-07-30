namespace ApiBlock.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class IsSubscription : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Customers", "IsSubcribeToNewsletter", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Customers", "IsSubcribeToNewsletter");
        }
    }
}
