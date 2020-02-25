namespace KafeKodTekrar1
{
    partial class GecmiSiparislerForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvSiparisler = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvSiparisDetaylari = new System.Windows.Forms.DataGridView();
            this.clmMasaNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAcilisZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmKapanisZamani = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmDurum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmOdenenTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmToplamTutar = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUrunAd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmBirimFiyati = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAdet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSiparisler
            // 
            this.dgvSiparisler.AllowUserToAddRows = false;
            this.dgvSiparisler.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisler.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisler.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisler.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisler.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmMasaNo,
            this.clmAcilisZamani,
            this.clmKapanisZamani,
            this.clmDurum,
            this.clmOdenenTutar,
            this.clmToplamTutar});
            this.dgvSiparisler.Location = new System.Drawing.Point(16, 46);
            this.dgvSiparisler.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSiparisler.Name = "dgvSiparisler";
            this.dgvSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisler.Size = new System.Drawing.Size(750, 358);
            this.dgvSiparisler.TabIndex = 2;
            this.dgvSiparisler.SelectionChanged += new System.EventHandler(this.dgvSiparisler_SelectionChanged);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(16, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "Siparişler";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(16, 408);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sipariş Detayları";
            // 
            // dgvSiparisDetaylari
            // 
            this.dgvSiparisDetaylari.AllowUserToAddRows = false;
            this.dgvSiparisDetaylari.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSiparisDetaylari.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSiparisDetaylari.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSiparisDetaylari.BackgroundColor = System.Drawing.SystemColors.HighlightText;
            this.dgvSiparisDetaylari.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSiparisDetaylari.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmUrunAd,
            this.clmBirimFiyati,
            this.clmAdet});
            this.dgvSiparisDetaylari.Location = new System.Drawing.Point(16, 430);
            this.dgvSiparisDetaylari.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvSiparisDetaylari.Name = "dgvSiparisDetaylari";
            this.dgvSiparisDetaylari.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSiparisDetaylari.Size = new System.Drawing.Size(750, 331);
            this.dgvSiparisDetaylari.TabIndex = 5;
            // 
            // clmMasaNo
            // 
            this.clmMasaNo.DataPropertyName = "masaNo";
            this.clmMasaNo.HeaderText = "Masa Numarası";
            this.clmMasaNo.Name = "clmMasaNo";
            // 
            // clmAcilisZamani
            // 
            this.clmAcilisZamani.DataPropertyName = "acilisZamani";
            this.clmAcilisZamani.HeaderText = "Aciliş Zamanı";
            this.clmAcilisZamani.Name = "clmAcilisZamani";
            // 
            // clmKapanisZamani
            // 
            this.clmKapanisZamani.DataPropertyName = "kapanisZamani";
            this.clmKapanisZamani.HeaderText = "Kapanış Zamanı";
            this.clmKapanisZamani.Name = "clmKapanisZamani";
            // 
            // clmDurum
            // 
            this.clmDurum.DataPropertyName = "durum";
            this.clmDurum.HeaderText = "Durum";
            this.clmDurum.Name = "clmDurum";
            // 
            // clmOdenenTutar
            // 
            this.clmOdenenTutar.DataPropertyName = "odenenTutar";
            this.clmOdenenTutar.HeaderText = "Ödenen Tutar";
            this.clmOdenenTutar.Name = "clmOdenenTutar";
            // 
            // clmToplamTutar
            // 
            this.clmToplamTutar.DataPropertyName = "ToplamTutarTL";
            this.clmToplamTutar.HeaderText = "Toplam Tutar";
            this.clmToplamTutar.Name = "clmToplamTutar";
            // 
            // clmUrunAd
            // 
            this.clmUrunAd.DataPropertyName = "urunAd";
            this.clmUrunAd.HeaderText = "Ürün Adı";
            this.clmUrunAd.Name = "clmUrunAd";
            // 
            // clmBirimFiyati
            // 
            this.clmBirimFiyati.DataPropertyName = "birimFiyat";
            this.clmBirimFiyati.HeaderText = "Birim Fiyatı";
            this.clmBirimFiyati.Name = "clmBirimFiyati";
            // 
            // clmAdet
            // 
            this.clmAdet.DataPropertyName = "adet";
            this.clmAdet.HeaderText = "Adet";
            this.clmAdet.Name = "clmAdet";
            // 
            // GecmiSiparislerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(778, 766);
            this.Controls.Add(this.dgvSiparisDetaylari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvSiparisler);
            this.Font = new System.Drawing.Font("Arial Narrow", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "GecmiSiparislerForm";
            this.Text = "GecmiSiparislerForm";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSiparisDetaylari)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvSiparisler;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSiparisDetaylari;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMasaNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAcilisZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmKapanisZamani;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmDurum;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmOdenenTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmToplamTutar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUrunAd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBirimFiyati;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAdet;
    }
}