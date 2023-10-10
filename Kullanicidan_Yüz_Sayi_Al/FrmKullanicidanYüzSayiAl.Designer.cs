namespace Kullanicidan_Yüz_Sayi_Al
{
    partial class FrmKullanicidanYüzSayiAl
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
            this.LblSonuc = new System.Windows.Forms.Label();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.LstEklenenSayilar = new System.Windows.Forms.ListBox();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtEklenenSayi = new System.Windows.Forms.TextBox();
            this.LblSayiEkle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(358, 16);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 26;
            this.LblSonuc.Text = "0";
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(24, 300);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(244, 34);
            this.BtnYazdir.TabIndex = 25;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // LstEklenenSayilar
            // 
            this.LstEklenenSayilar.FormattingEnabled = true;
            this.LstEklenenSayilar.ItemHeight = 21;
            this.LstEklenenSayilar.Location = new System.Drawing.Point(24, 80);
            this.LstEklenenSayilar.Name = "LstEklenenSayilar";
            this.LstEklenenSayilar.Size = new System.Drawing.Size(244, 214);
            this.LstEklenenSayilar.TabIndex = 24;
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(295, 16);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 23;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(24, 47);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(244, 27);
            this.BtnEkle.TabIndex = 22;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtEklenenSayi
            // 
            this.TxtEklenenSayi.Location = new System.Drawing.Point(112, 12);
            this.TxtEklenenSayi.Name = "TxtEklenenSayi";
            this.TxtEklenenSayi.Size = new System.Drawing.Size(156, 29);
            this.TxtEklenenSayi.TabIndex = 21;
            // 
            // LblSayiEkle
            // 
            this.LblSayiEkle.AutoSize = true;
            this.LblSayiEkle.Location = new System.Drawing.Point(20, 16);
            this.LblSayiEkle.Name = "LblSayiEkle";
            this.LblSayiEkle.Size = new System.Drawing.Size(86, 21);
            this.LblSayiEkle.TabIndex = 20;
            this.LblSayiEkle.Text = "Sayı Ekle :";
            // 
            // FrmKullanicidanYüzSayiAl
            // 
            this.AcceptButton = this.BtnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 356);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.LstEklenenSayilar);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtEklenenSayi);
            this.Controls.Add(this.LblSayiEkle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKullanicidanYüzSayiAl";
            this.Text = "FrmKullanicidanYüzSayiAl";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSonuc;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.ListBox LstEklenenSayilar;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtEklenenSayi;
        private System.Windows.Forms.Label LblSayiEkle;
    }
}

