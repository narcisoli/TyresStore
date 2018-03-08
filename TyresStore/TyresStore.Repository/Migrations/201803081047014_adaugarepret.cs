namespace TyresStore.Repository.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class adaugarepret : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Basket", "pret", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Basket", "pret");
        }
    }
}
