namespace KafeKod.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class CascadeDel : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.SiparisDetay", "UrunId", "dbo.Urunler");
            AddForeignKey("dbo.SiparisDetay", "UrunId", "dbo.Urunler", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SiparisDetay", "UrunId", "dbo.Urunler");
            AddForeignKey("dbo.SiparisDetay", "UrunId", "dbo.Urunler", "Id", cascadeDelete: true);
        }
    }
}
