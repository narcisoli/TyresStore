namespace TyresStore.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeid : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Basket");
            AlterColumn("dbo.Basket", "TyreId", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Basket", "TyreId");
            DropColumn("dbo.Basket", "ID");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Basket", "ID", c => c.Int(nullable: false, identity: true));
            DropPrimaryKey("dbo.Basket");
            AlterColumn("dbo.Basket", "TyreId", c => c.Int(nullable: false));
            AddPrimaryKey("dbo.Basket", "ID");
        }
    }
}
