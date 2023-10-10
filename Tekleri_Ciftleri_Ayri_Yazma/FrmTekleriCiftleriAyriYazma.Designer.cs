namespace Tekleri_Ciftleri_Ayri_Yazma
{
    partial class FrmTekleriCiftleriAyriYazma
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
            this.LblCiftler = new System.Windows.Forms.Label();
            this.LstCiftler = new System.Windows.Forms.ListBox();
            this.LstTekler = new System.Windows.Forms.ListBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.LstEklenenSayilar = new System.Windows.Forms.ListBox();
            this.LblTekler = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.TxtEklenenSayi = new System.Windows.Forms.TextBox();
            this.LblSayiEkle = new System.Windows.Forms.Label();
            this.BtnSayiAl = new System.Windows.Forms.Button();
            this.TxtGirilenSayi = new System.Windows.Forms.TextBox();
            this.LblSayiGiriniz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblCiftler
            // 
            this.LblCiftler.AutoSize = true;
            this.LblCiftler.Location = new System.Drawing.Point(640, 28);
            this.LblCiftler.Name = "LblCiftler";
            this.LblCiftler.Size = new System.Drawing.Size(65, 21);
            this.LblCiftler.TabIndex = 33;
            this.LblCiftler.Text = "Çiftler :";
            // 
            // LstCiftler
            // 
            this.LstCiftler.FormattingEnabled = true;
            this.LstCiftler.ItemHeight = 21;
            this.LstCiftler.Location = new System.Drawing.Point(640, 72);
            this.LstCiftler.Name = "LstCiftler";
            this.LstCiftler.Size = new System.Drawing.Size(119, 235);
            this.LstCiftler.TabIndex = 32;
            // 
            // LstTekler
            // 
            this.LstTekler.FormattingEnabled = true;
            this.LstTekler.ItemHeight = 21;
            this.LstTekler.Location = new System.Drawing.Point(502, 72);
            this.LstTekler.Name = "LstTekler";
            this.LstTekler.Size = new System.Drawing.Size(119, 235);
            this.LstTekler.TabIndex = 31;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Enabled = false;
            this.BtnYazdir.Location = new System.Drawing.Point(506, 313);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(244, 34);
            this.BtnYazdir.TabIndex = 30;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // LstEklenenSayilar
            // 
            this.LstEklenenSayilar.FormattingEnabled = true;
            this.LstEklenenSayilar.ItemHeight = 21;
            this.LstEklenenSayilar.Location = new System.Drawing.Point(231, 92);
            this.LstEklenenSayilar.Name = "LstEklenenSayilar";
            this.LstEklenenSayilar.Size = new System.Drawing.Size(244, 214);
            this.LstEklenenSayilar.TabIndex = 29;
            // 
            // LblTekler
            // 
            this.LblTekler.AutoSize = true;
            this.LblTekler.Location = new System.Drawing.Point(502, 28);
            this.LblTekler.Name = "LblTekler";
            this.LblTekler.Size = new System.Drawing.Size(64, 21);
            this.LblTekler.TabIndex = 28;
            this.LblTekler.Text = "Tekler :";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Enabled = false;
            this.BtnEkle.Location = new System.Drawing.Point(231, 59);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(244, 27);
            this.BtnEkle.TabIndex = 27;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // TxtEklenenSayi
            // 
            this.TxtEklenenSayi.Enabled = false;
            this.TxtEklenenSayi.Location = new System.Drawing.Point(319, 24);
            this.TxtEklenenSayi.Name = "TxtEklenenSayi";
            this.TxtEklenenSayi.Size = new System.Drawing.Size(156, 29);
            this.TxtEklenenSayi.TabIndex = 26;
            // 
            // LblSayiEkle
            // 
            this.LblSayiEkle.AutoSize = true;
            this.LblSayiEkle.Location = new System.Drawing.Point(227, 28);
            this.LblSayiEkle.Name = "LblSayiEkle";
            this.LblSayiEkle.Size = new System.Drawing.Size(86, 21);
            this.LblSayiEkle.TabIndex = 25;
            this.LblSayiEkle.Text = "Sayı Ekle :";
            // 
            // BtnSayiAl
            // 
            this.BtnSayiAl.Location = new System.Drawing.Point(24, 59);
            this.BtnSayiAl.Name = "BtnSayiAl";
            this.BtnSayiAl.Size = new System.Drawing.Size(182, 27);
            this.BtnSayiAl.TabIndex = 24;
            this.BtnSayiAl.Text = "Sayı Al";
            this.BtnSayiAl.UseVisualStyleBackColor = true;
            this.BtnSayiAl.Click += new System.EventHandler(this.BtnSayiAl_Click);
            // 
            // TxtGirilenSayi
            // 
            this.TxtGirilenSayi.Location = new System.Drawing.Point(130, 24);
            this.TxtGirilenSayi.Name = "TxtGirilenSayi";
            this.TxtGirilenSayi.Size = new System.Drawing.Size(76, 29);
            this.TxtGirilenSayi.TabIndex = 23;
            // 
            // LblSayiGiriniz
            // 
            this.LblSayiGiriniz.AutoSize = true;
            this.LblSayiGiriniz.Location = new System.Drawing.Point(20, 28);
            this.LblSayiGiriniz.Name = "LblSayiGiriniz";
            this.LblSayiGiriniz.Size = new System.Drawing.Size(104, 21);
            this.LblSayiGiriniz.TabIndex = 22;
            this.LblSayiGiriniz.Text = "Sayı Giriniz :";
            // 
            // FrmTekleriCiftleriAyriYazma
            // 
            this.AcceptButton = this.BtnSayiAl;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(812, 443);
            this.Controls.Add(this.LblCiftler);
            this.Controls.Add(this.LstCiftler);
            this.Controls.Add(this.LstTekler);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.LstEklenenSayilar);
            this.Controls.Add(this.LblTekler);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtEklenenSayi);
            this.Controls.Add(this.LblSayiEkle);
            this.Controls.Add(this.BtnSayiAl);
            this.Controls.Add(this.TxtGirilenSayi);
            this.Controls.Add(this.LblSayiGiriniz);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTekleriCiftleriAyriYazma";
            this.Text = "FrmTekleriCiftleriAyriYazma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblCiftler;
        private System.Windows.Forms.ListBox LstCiftler;
        private System.Windows.Forms.ListBox LstTekler;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.ListBox LstEklenenSayilar;
        private System.Windows.Forms.Label LblTekler;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.TextBox TxtEklenenSayi;
        private System.Windows.Forms.Label LblSayiEkle;
        private System.Windows.Forms.Button BtnSayiAl;
        private System.Windows.Forms.TextBox TxtGirilenSayi;
        private System.Windows.Forms.Label LblSayiGiriniz;
    }
}

