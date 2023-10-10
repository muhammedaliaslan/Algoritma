namespace KullanicininGirdigiSayilariTerstenSirala
{
    partial class FrmKullanicininGirdigiSayilariTerstenSirala
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
            this.lstSonuc = new System.Windows.Forms.ListBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lstEklenenSayilar = new System.Windows.Forms.ListBox();
            this.lblSonucBilgi = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEklenenSayi = new System.Windows.Forms.TextBox();
            this.lblSayiEkle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstSonuc
            // 
            this.lstSonuc.FormattingEnabled = true;
            this.lstSonuc.ItemHeight = 28;
            this.lstSonuc.Location = new System.Drawing.Point(336, 96);
            this.lstSonuc.Name = "lstSonuc";
            this.lstSonuc.Size = new System.Drawing.Size(244, 228);
            this.lstSonuc.TabIndex = 26;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(336, 340);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(244, 34);
            this.btnYazdir.TabIndex = 25;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // lstEklenenSayilar
            // 
            this.lstEklenenSayilar.FormattingEnabled = true;
            this.lstEklenenSayilar.ItemHeight = 28;
            this.lstEklenenSayilar.Location = new System.Drawing.Point(65, 124);
            this.lstEklenenSayilar.Name = "lstEklenenSayilar";
            this.lstEklenenSayilar.Size = new System.Drawing.Size(244, 200);
            this.lstEklenenSayilar.TabIndex = 24;
            // 
            // lblSonucBilgi
            // 
            this.lblSonucBilgi.AutoSize = true;
            this.lblSonucBilgi.Location = new System.Drawing.Point(344, 49);
            this.lblSonucBilgi.Name = "lblSonucBilgi";
            this.lblSonucBilgi.Size = new System.Drawing.Size(80, 28);
            this.lblSonucBilgi.TabIndex = 23;
            this.lblSonucBilgi.Text = "Sonuç :";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(65, 87);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(244, 34);
            this.btnEkle.TabIndex = 22;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // txtEklenenSayi
            // 
            this.txtEklenenSayi.Location = new System.Drawing.Point(167, 46);
            this.txtEklenenSayi.Name = "txtEklenenSayi";
            this.txtEklenenSayi.Size = new System.Drawing.Size(142, 34);
            this.txtEklenenSayi.TabIndex = 21;
            // 
            // lblSayiEkle
            // 
            this.lblSayiEkle.AutoSize = true;
            this.lblSayiEkle.Location = new System.Drawing.Point(61, 49);
            this.lblSayiEkle.Name = "lblSayiEkle";
            this.lblSayiEkle.Size = new System.Drawing.Size(107, 28);
            this.lblSayiEkle.TabIndex = 20;
            this.lblSayiEkle.Text = "Sayı Ekle :";
            // 
            // FrmKullanicininGirdigiSayilariTerstenSirala
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(923, 532);
            this.Controls.Add(this.lstSonuc);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lstEklenenSayilar);
            this.Controls.Add(this.lblSonucBilgi);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEklenenSayi);
            this.Controls.Add(this.lblSayiEkle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKullanicininGirdigiSayilariTerstenSirala";
            this.Text = "FrmKullanicininGirdigiSayilariTerstenSirala";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstSonuc;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ListBox lstEklenenSayilar;
        private System.Windows.Forms.Label lblSonucBilgi;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEklenenSayi;
        private System.Windows.Forms.Label lblSayiEkle;
    }
}

