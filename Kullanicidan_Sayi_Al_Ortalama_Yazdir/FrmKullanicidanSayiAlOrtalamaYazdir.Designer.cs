namespace Kullanicidan_Sayi_Al_Ortalama_Yazdir
{
    partial class FrmKullanicidanSayiAlOrtalamaYazdir
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
            this.LblSayiGiriniz = new System.Windows.Forms.Label();
            this.TxtGirilenSayi = new System.Windows.Forms.TextBox();
            this.BtnSayiAl = new System.Windows.Forms.Button();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtEklenenSayi = new System.Windows.Forms.TextBox();
            this.LblSayiEkle = new System.Windows.Forms.Label();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.LstEklenenSayilar = new System.Windows.Forms.ListBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblSayiGiriniz
            // 
            this.LblSayiGiriniz.AutoSize = true;
            this.LblSayiGiriniz.Location = new System.Drawing.Point(8, 25);
            this.LblSayiGiriniz.Name = "LblSayiGiriniz";
            this.LblSayiGiriniz.Size = new System.Drawing.Size(104, 21);
            this.LblSayiGiriniz.TabIndex = 0;
            this.LblSayiGiriniz.Text = "Sayı Giriniz :";
            // 
            // TxtGirilenSayi
            // 
            this.TxtGirilenSayi.Location = new System.Drawing.Point(118, 22);
            this.TxtGirilenSayi.Name = "TxtGirilenSayi";
            this.TxtGirilenSayi.Size = new System.Drawing.Size(76, 29);
            this.TxtGirilenSayi.TabIndex = 1;
            // 
            // BtnSayiAl
            // 
            this.BtnSayiAl.Location = new System.Drawing.Point(12, 56);
            this.BtnSayiAl.Name = "BtnSayiAl";
            this.BtnSayiAl.Size = new System.Drawing.Size(182, 27);
            this.BtnSayiAl.TabIndex = 2;
            this.BtnSayiAl.Text = "Sayı Al";
            this.BtnSayiAl.UseVisualStyleBackColor = true;
            this.BtnSayiAl.Click += new System.EventHandler(this.BtnSayiAl_Click);
            // 
            // BtnEkle
            // 
            this.BtnEkle.Enabled = false;
            this.BtnEkle.Location = new System.Drawing.Point(219, 56);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(244, 27);
            this.BtnEkle.TabIndex = 5;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtEklenenSayi
            // 
            this.TxtEklenenSayi.Enabled = false;
            this.TxtEklenenSayi.Location = new System.Drawing.Point(307, 21);
            this.TxtEklenenSayi.Name = "TxtEklenenSayi";
            this.TxtEklenenSayi.Size = new System.Drawing.Size(156, 29);
            this.TxtEklenenSayi.TabIndex = 4;
            // 
            // LblSayiEkle
            // 
            this.LblSayiEkle.AutoSize = true;
            this.LblSayiEkle.Location = new System.Drawing.Point(215, 25);
            this.LblSayiEkle.Name = "LblSayiEkle";
            this.LblSayiEkle.Size = new System.Drawing.Size(86, 21);
            this.LblSayiEkle.TabIndex = 3;
            this.LblSayiEkle.Text = "Sayı Ekle :";
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(490, 25);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 6;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // LstEklenenSayilar
            // 
            this.LstEklenenSayilar.FormattingEnabled = true;
            this.LstEklenenSayilar.ItemHeight = 21;
            this.LstEklenenSayilar.Location = new System.Drawing.Point(219, 89);
            this.LstEklenenSayilar.Name = "LstEklenenSayilar";
            this.LstEklenenSayilar.Size = new System.Drawing.Size(244, 214);
            this.LstEklenenSayilar.TabIndex = 7;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Enabled = false;
            this.BtnYazdir.Location = new System.Drawing.Point(219, 309);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(244, 34);
            this.BtnYazdir.TabIndex = 8;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(553, 25);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 9;
            this.LblSonuc.Text = "0";
            // 
            // FrmKullanicidanSayiAlOrtalamaYazdir
            // 
            this.AcceptButton = this.BtnSayiAl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 381);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.LstEklenenSayilar);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtEklenenSayi);
            this.Controls.Add(this.LblSayiEkle);
            this.Controls.Add(this.BtnSayiAl);
            this.Controls.Add(this.TxtGirilenSayi);
            this.Controls.Add(this.LblSayiGiriniz);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKullanicidanSayiAlOrtalamaYazdir";
            this.Text = "FrmKullanicidanSayiAlOrtalamaYazdir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSayiGiriniz;
        private System.Windows.Forms.TextBox TxtGirilenSayi;
        private System.Windows.Forms.Button BtnSayiAl;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtEklenenSayi;
        private System.Windows.Forms.Label LblSayiEkle;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.ListBox LstEklenenSayilar;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Label LblSonuc;
    }
}

