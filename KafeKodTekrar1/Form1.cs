using KafeKod.Data;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKodTekrar1
{
    public partial class Form1 : Form
    {
        // Formun açılışında KafeKod.Data'dan  KafeVeri clasından degişken oluşturuyoruz. 
        KafeVeri db;

        public Form1()
        {
            // Veri.json dosyasındaki verilerin okunmasını saglıyoruz.
            VerileriOku();
            InitializeComponent();
            // masalari oluştururken iconların imajlarını hazırlıyoruz.
            // Masa dolu ise farkli image boş ise farkli bir image geliyor.
            //Imagelarımızı olusturduktan sonra for dongusu ile kafeveride tanımladıgımız masaadeti kadar Listview'e masa ekliyoruz.
            MasalariOlustur();
        }

        private void MasalariOlustur()
        {

            #region ListView İmajlarının Hazırlanması
            // İl isminde ListImage oluşturuyoruz. Imageların durumunu bunun içinde saklıyacagız.
            ImageList il = new ImageList();
            //Properties.Resource.Masabos adresindeki resmi bos masa imageı olarak eklıyoruz.
            il.Images.Add("bos", Properties.Resources.masabos);
            //Yukarıdaki işlemin aynısını dolu masa içinde gerceklestırıyoruz.
            il.Images.Add("dolu", Properties.Resources.masadolu);
            // Oluşturacagımız İmagelerin boyutlarını 64,64 kare şeklinde oluşturuyoruz.
            il.ImageSize = new Size(90,90);
            // ListViewimiz olan lvwMasalarin Imagelarını buyuk boy olarak ayarlıyoruz.
            lvwMasalar.LargeImageList = il;
            #endregion

            //Oluşturacagımız masaları item olarak ListViewİtem  ile tanımladıgımız lvi içine atacagız.
            ListViewItem lvi;
            //KafeVerinin içindeki masaadeti kadar burada for ile masa ekliyoruz.
            for (int i = 1; i <= db.MasaAdet; i++)
            {
                //ekliyeceğimiz masaların isimlerini i ile dondererek dondererek sayılar atıyoruz. 
                lvi = new ListViewItem("Masa " + i);
                //FirstOtDefault = Bu tür bir öğe bulunamazsa, bir koşulu karşılayan dizinin ilk öğesini veya varsayılan değeri döndürür.
                //Aktifsiparişlerin dolumu boşmu oldugu kontrol edilip aşağıdaki if kontrolünü saglıyoruz.
                Siparis sip = db.AktifSiparisler.FirstOrDefault(x => x.MasaNo == i); 
                //sip degişkenimiz null degerde yani boş ise 
                if (sip == null)
                {
                    //lvi'nin tagını i den çekiyıoruz.
                    lvi.Tag = i;
                    // ve durumunu boş masa olarak ayarlıyoruz.
                    lvi.ImageKey = "bos";
                }
                else
                {
                    //Sip bos yanı null degilse  sip degişkenini  Lvi'nin tagına atıyoruz.
                    lvi.Tag = sip;
                    //ve durumunu dolu masa olarak ayarlıyoruz.
                    lvi.ImageKey = "dolu";
                }
                // lvwMasalar listview'de 
                lvwMasalar.Items.Add(lvi);
            }
            
        }

        private void VerileriOku() // Veri.json dosyamızda bulunan vbilgileri deserilization yontemi ile cagırıyoruz. 
        {
            try
            {
                //Verilerin okunmasında hata olması durumuna karşın try catch olarak 
                //içinde veri çağırma işlemini gerçekleştiriyoruz.
                //verileri tutacagımız strin degıskenını tanımlayarak json formatındakı dosyamızı atama işlemiyle aktarıyoruz.
                string json = File.ReadAllText("veri.json");
                //Kafeveri  için tanımladıgımız db nin içine olusturdugumuz json degıskenı ıle donusturerek  dbnin içine aktarıyoruz.
                db = JsonConvert.DeserializeObject<KafeVeri>(json);
            }
            catch (Exception)
            {
                //catch'te excepsiın yakalaması durumunda 
                //db yi yeniden olusturuyoruz.
                //işlemlerin tekrardan yapılabılmesını saglıyoruz.
                db = new KafeVeri();
            }
        }

        private void OrnekVerileriYukle()
        {
            db.Urunler = new List<Urun>
            {
                new Urun{UrunAd = "Kola", BirimFiyat = 6.99m },
                new Urun{UrunAd = "Fanta", BirimFiyat = 7.99m }
            };
            db.Urunler.Sort();
        }

        private void lvwMasalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            //ListViewMasalar objesine mouse eventi atayarak sol tıklanarak işlemleri gercekleştırmesı saglıyoruz.
            if (e.Button == MouseButtons.Left)
            {
                //ListViewMasalar objesinde secili itemi lvi degıskenıne atıyoruz.(burada 0 harıcı bir deger girdiğimizde deger ataması hatası alıyoruz.)
                var lvi = lvwMasalar.SelectedItems[0];
                //Burada 0 olmasının ıkıncı sebebıde  masanın bos oldugunu belırtmek 
                //lvi nin ImageKeyıne 'bos' ataması yapıyoruz.
                lvi.ImageKey = "bos";

                Siparis sip;
                
                if (lvi.Tag is Siparis)
                {
                    sip = (Siparis)lvi.Tag;
                }
                else
                {
                    sip = new Siparis();
                    sip.MasaNo = (int)lvi.Tag;
                    sip.AcilisZamani = DateTime.Now;
                    lvi.Tag = sip;
                    db.AktifSiparisler.Add(sip);
                }
                SiparisForm frmSiparis = new SiparisForm(db, sip);
                frmSiparis.MasaTasiniyor += FrmSiparis_MasaTasindi;
                frmSiparis.ShowDialog();

                if (sip.Durum == SiparisDurum.Odendi || sip.Durum == SiparisDurum.Iptal)
                {
                    lvi.Tag = sip.MasaNo;
                    lvi.ImageKey = "bos";
                    db.AktifSiparisler.Remove(sip);
                    db.GecmisSiparisler.Add(sip);
                }

            }
        }

        private void FrmSiparis_MasaTasindi(object sender, MasaTasimaEventArgs e)
        {
            ListViewItem lviEskiMasa = MasaBul(e.EskiMasaNo);
            lviEskiMasa.Tag = e.TasinanSiparis;
            lviEskiMasa.ImageKey = "bos";

            ListViewItem lviYeniMasa = MasaBul(e.YeniMasaNo);
            lviEskiMasa.Tag = e.TasinanSiparis;
            lviEskiMasa.ImageKey = "dolu";

        }

        private ListViewItem MasaBul(int masaNo)
        {
            foreach (ListViewItem item in lvwMasalar.Items)
            {
                if (item.Tag is int && (int)item.Tag == masaNo)
                {
                    return item;
                }
                else if (item.Tag is Siparis && ((Siparis)item.Tag).MasaNo == masaNo)
                {
                    return item;
                }
            }
            return null;
        }

        private void tsmiGecmisSiparisler_Click(object sender, EventArgs e)
        {
            var frm = new GecmiSiparislerForm(db);
            frm.ShowDialog();
        }

        private void tsmiUrunler_Click(object sender, EventArgs e)
        {
            OrnekVerileriYukle();
            var frm = new UrunlerForm(db);
            frm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            string json = JsonConvert.SerializeObject(db);
            File.WriteAllText("veri.json", json);
        }
    }
}
