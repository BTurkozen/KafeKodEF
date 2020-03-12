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
        KafeContex db = new KafeContex();
        

        public Form1()
        {
            InitializeComponent();  
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

            lvwMasalar.Items.Clear();
            ListViewItem lvi;
           
            for (int i = 1; i <= Properties.Settings.Default.MasaAdet; i++)
            {
                
                lvi = new ListViewItem("Masa " + i);
                
                Siparis sip = db.Siparisler.FirstOrDefault
                    (x => x.MasaNo == i && x.Durum == SiparisDurum.Aktif); 
               
                if (sip == null)
                { 
                    lvi.Tag = i; 
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
                db.SaveChanges();
            }
            
        }

        private void lvwMasalar_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var lvi = lvwMasalar.SelectedItems[0];
                lvi.ImageKey = "bos";

                Siparis sip;
                
                if (lvi.Tag is Siparis)
                {
                    sip = (Siparis)lvi.Tag;
                }
                else
                {
                    sip = new Siparis();
                    sip.Durum = SiparisDurum.Aktif;
                    sip.MasaNo = (int)lvi.Tag;
                    sip.AcilisZamani = DateTime.Now;
                    lvi.Tag = sip;
                    db.Siparisler.Add(sip);
                    db.SaveChanges();
                }
                SiparisForm frmSiparis = new SiparisForm(db, sip);
                frmSiparis.MasaTasiniyor += FrmSiparis_MasaTasindi;
                frmSiparis.ShowDialog();

                if (sip.Durum == SiparisDurum.Odendi || sip.Durum == SiparisDurum.Iptal)
                {
                    lvi.Tag = sip.MasaNo;
                    lvi.ImageKey = "bos";
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
            var frm = new UrunlerForm(db);
            frm.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            db.Dispose();
        }

        private void tsmiAyarlar_Click(object sender, EventArgs e)
        {
            var frm = new AyarlarForm();
            DialogResult dr = frm.ShowDialog();
            if (dr == DialogResult.OK)
            {
                MasalariOlustur();
            }
        }
    }
}
