namespace TyresStore.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Mig3cantitate : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Basket", "cant", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Basket", "cant");
        }
    }
}
