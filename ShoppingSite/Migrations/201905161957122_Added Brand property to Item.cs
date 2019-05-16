namespace ShoppingSite.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedBrandpropertytoItem : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Items", "Brand", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Items", "Brand");
        }
    }
}
