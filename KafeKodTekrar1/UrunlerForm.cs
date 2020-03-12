using KafeKod.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KafeKodTekrar1
{
    public partial class UrunlerForm : Form
    {
        KafeContex db;
        public UrunlerForm(KafeContex _kafeVeri)
        {
            db = _kafeVeri;
            InitializeComponent();
            dgvUrunler.AutoGenerateColumns = false;
            dgvUrunler.DataSource = db.Urunler.ToList();
            dgvUrunler.DataSource =
                new BindingSource(db.Urunler.
                OrderBy(x => x.UrunAd).
                ToList(), null);
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            string urunAd = txtUrunAd.Text.Trim();
            if (urunAd == "")
            {
                MessageBox.Show("Lütfen Bir Ürün Adı Seçiniz.");
                return;
            }
            db.Urunler.Add(new Urun
            {
                UrunAd = urunAd,
                BirimFiyat = nudBirimFiyat.Value

            });
            db.SaveChanges();
            dgvUrunler.DataSource = 
                new BindingSource(db.Urunler.
                OrderBy(x => x.UrunAd).
                ToList(), null);
        }

        private void dgvUrunler_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("Geçersiz Bir Değer Girdiniz.");
        }

        private void dgvUrunler_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                if (e.FormattedValue.ToString().Trim() == "")
                {
                    dgvUrunler.Rows[e.RowIndex].ErrorText = "Ürün Ad Boş Geçilemez.";
                    e.Cancel = true;
                }
                else
                {
                    dgvUrunler.Rows[e.RowIndex].ErrorText = "";                  
                }    
            }
            db.SaveChanges();
        }

        private void dgvUrunler_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            Urun urun = (Urun)e.Row.DataBoundItem;

            if (urun.SiparisDetays.Count > 0)
            {
                MessageBox.Show("Bu ürün geçmiş siparişlerde ilişkili olduğu için silinemez!!!");
                e.Cancel = true;
                return;   
            }
            db.Urunler.Remove(urun);
            db.SaveChanges();
        }

        private void UrunlerForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            txtUrunAd.Focus();
        }
    }
}
