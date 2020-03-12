using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KafeKod.Data
{
    public class KafeContex : DbContext
    {
        public KafeContex() : base("name = KafeContex")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.
            //    Entity<Urun>().
            //    ToTable("Ürünler");

            modelBuilder.
                Entity<Urun>().
                HasMany(x => x.SiparisDetays).
                WithRequired(x => x.Urun).
                HasForeignKey(x => x.UrunId).
                WillCascadeOnDelete(false);
        }
        public DbSet<Urun> Urunler { get; set; }
        public DbSet<Siparis> Siparisler { get; set; }
        public DbSet<SiparisDetay> SiparisDetay { get; set; }
        
    }
}
