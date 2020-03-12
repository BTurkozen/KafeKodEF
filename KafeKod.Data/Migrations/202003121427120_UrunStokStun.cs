namespace KafeKod.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UrunStokStun : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Urunler", "StokdaYok", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Urunler", "StokdaYok");
        }
    }
}
