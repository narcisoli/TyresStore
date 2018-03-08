namespace TyresStore.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBasket : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Basket");
            AddColumn("dbo.Basket", "ID", c => c.Int(nullable: false, identity: true));
            AlterColumn("dbo.Basket", "TyreId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Basket", "ID");
            DropColumn("dbo.Basket", "Description");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Basket", "Description", c => c.String());
            DropPrimaryKey("dbo.Basket");
            AlterColumn("dbo.Basket", "TyreId", c => c.Int(nullable: false, identity: true));
            DropColumn("dbo.Basket", "ID");
            AddPrimaryKey("dbo.Basket", "TyreId");
        }
    }
}
