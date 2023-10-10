namespace Elli_Sayial_Buyuk_Cift_Sayi_Yaz
{
    partial class FrmElliSayiAlBuyukCiftSayiyiYaz
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
            this.LblSayiEkle = new System.Windows.Forms.Label();
            this.TxtEklenenSayilar = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LstEklenenSayilar = new System.Windows.Forms.ListBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblSayiEkle
            // 
            this.LblSayiEkle.AutoSize = true;
            this.LblSayiEkle.Location = new System.Drawing.Point(100, 56);
            this.LblSayiEkle.Name = "LblSayiEkle";
            this.LblSayiEkle.Size = new System.Drawing.Size(86, 21);
            this.LblSayiEkle.TabIndex = 0;
            this.LblSayiEkle.Text = "Sayı Ekle :";
            // 
            // TxtEklenenSayilar
            // 
            this.TxtEklenenSayilar.Location = new System.Drawing.Point(192, 53);
            this.TxtEklenenSayilar.Name = "TxtEklenenSayilar";
            this.TxtEklenenSayilar.Size = new System.Drawing.Size(132, 29);
            this.TxtEklenenSayilar.TabIndex = 1;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(104, 88);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(220, 31);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LstEklenenSayilar
            // 
            this.LstEklenenSayilar.FormattingEnabled = true;
            this.LstEklenenSayilar.ItemHeight = 21;
            this.LstEklenenSayilar.Location = new System.Drawing.Point(104, 125);
            this.LstEklenenSayilar.Name = "LstEklenenSayilar";
            this.LstEklenenSayilar.Size = new System.Drawing.Size(220, 193);
            this.LstEklenenSayilar.TabIndex = 3;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(104, 324);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(220, 31);
            this.BtnYazdir.TabIndex = 4;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(100, 377);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 5;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(172, 377);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 6;
            this.LblSonuc.Text = "0";
            // 
            // FrmElliSayiAlBuyukCiftSayiyiYaz
            // 
            this.AcceptButton = this.BtnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 468);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.LstEklenenSayilar);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtEklenenSayilar);
            this.Controls.Add(this.LblSayiEkle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmElliSayiAlBuyukCiftSayiyiYaz";
            this.Text = "FrmElliSayiAlBuyukCiftSayiyiYaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSayiEkle;
        private System.Windows.Forms.TextBox TxtEklenenSayilar;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ListBox LstEklenenSayilar;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.Label LblSonuc;
    }
}

