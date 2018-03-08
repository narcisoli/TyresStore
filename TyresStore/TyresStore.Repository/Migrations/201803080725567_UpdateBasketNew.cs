namespace TyresStore.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBasketNew : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Basket", "Description", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Basket", "Description");
        }
    }
}
