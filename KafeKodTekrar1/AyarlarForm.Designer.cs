namespace KafeKodTekrar1
{
    partial class AyarlarForm
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
            this.nudMasaAdet = new System.Windows.Forms.NumericUpDown();
            this.btnAyarKaydet = new System.Windows.Forms.Button();
            this.btnAyarIptal = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nudMasaAdet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nudMasaAdet
            // 
            this.nudMasaAdet.Location = new System.Drawing.Point(16, 32);
            this.nudMasaAdet.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.nudMasaAdet.Name = "nudMasaAdet";
            this.nudMasaAdet.Size = new System.Drawing.Size(200, 24);
            this.nudMasaAdet.TabIndex = 0;
            this.nudMasaAdet.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.Location = new System.Drawing.Point(16, 63);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(98, 37);
            this.btnAyarKaydet.TabIndex = 2;
            this.btnAyarKaydet.Text = "KAYDET";
            this.btnAyarKaydet.UseVisualStyleBackColor = true;
            this.btnAyarKaydet.Click += new System.EventHandler(this.btnAyarKaydet_Click);
            // 
            // btnAyarIptal
            // 
            this.btnAyarIptal.Location = new System.Drawing.Point(120, 63);
            this.btnAyarIptal.Name = "btnAyarIptal";
            this.btnAyarIptal.Size = new System.Drawing.Size(96, 37);
            this.btnAyarIptal.TabIndex = 3;
            this.btnAyarIptal.Text = "İPTAL";
            this.btnAyarIptal.UseVisualStyleBackColor = true;
            this.btnAyarIptal.Click += new System.EventHandler(this.btnAyarIptal_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.groupBox1.Controls.Add(this.btnAyarIptal);
            this.groupBox1.Controls.Add(this.nudMasaAdet);
            this.groupBox1.Controls.Add(this.btnAyarKaydet);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(232, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "MASA ADET";
            // 
            // AyarlarForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 142);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(272, 181);
            this.MinimumSize = new System.Drawing.Size(272, 181);
            this.Name = "AyarlarForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Ayarlar";
            ((System.ComponentModel.ISupportInitialize)(this.nudMasaAdet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NumericUpDown nudMasaAdet;
        private System.Windows.Forms.Button btnAyarKaydet;
        private System.Windows.Forms.Button btnAyarIptal;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}