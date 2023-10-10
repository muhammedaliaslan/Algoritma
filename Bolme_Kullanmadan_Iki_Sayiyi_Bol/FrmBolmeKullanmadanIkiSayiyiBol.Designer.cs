namespace Bolme_Kullanmadan_Iki_Sayiyi_Bol
{
    partial class FrmBolmeKullanmadanIkiSayiyiBol
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
            this.LblBirinciSayi = new System.Windows.Forms.Label();
            this.LblIkinciSayi = new System.Windows.Forms.Label();
            this.TxtSayiBir = new System.Windows.Forms.TextBox();
            this.TxtSayiIki = new System.Windows.Forms.TextBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.LblKalanBilgi = new System.Windows.Forms.Label();
            this.LblKalan = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblBirinciSayi
            // 
            this.LblBirinciSayi.AutoSize = true;
            this.LblBirinciSayi.Location = new System.Drawing.Point(83, 38);
            this.LblBirinciSayi.Name = "LblBirinciSayi";
            this.LblBirinciSayi.Size = new System.Drawing.Size(63, 21);
            this.LblBirinciSayi.TabIndex = 0;
            this.LblBirinciSayi.Text = "1.Sayı :";
            // 
            // LblIkinciSayi
            // 
            this.LblIkinciSayi.AutoSize = true;
            this.LblIkinciSayi.Location = new System.Drawing.Point(83, 88);
            this.LblIkinciSayi.Name = "LblIkinciSayi";
            this.LblIkinciSayi.Size = new System.Drawing.Size(63, 21);
            this.LblIkinciSayi.TabIndex = 1;
            this.LblIkinciSayi.Text = "2.Sayı :";
            // 
            // TxtSayiBir
            // 
            this.TxtSayiBir.Location = new System.Drawing.Point(146, 34);
            this.TxtSayiBir.Name = "TxtSayiBir";
            this.TxtSayiBir.Size = new System.Drawing.Size(100, 29);
            this.TxtSayiBir.TabIndex = 2;
            // 
            // TxtSayiIki
            // 
            this.TxtSayiIki.Location = new System.Drawing.Point(146, 84);
            this.TxtSayiIki.Name = "TxtSayiIki";
            this.TxtSayiIki.Size = new System.Drawing.Size(100, 29);
            this.TxtSayiIki.TabIndex = 3;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(146, 130);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(100, 28);
            this.BtnYazdir.TabIndex = 4;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(83, 178);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 5;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(155, 178);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(28, 21);
            this.LblSonuc.TabIndex = 6;
            this.LblSonuc.Text = "00";
            // 
            // LblKalanBilgi
            // 
            this.LblKalanBilgi.AutoSize = true;
            this.LblKalanBilgi.Location = new System.Drawing.Point(85, 210);
            this.LblKalanBilgi.Name = "LblKalanBilgi";
            this.LblKalanBilgi.Size = new System.Drawing.Size(61, 21);
            this.LblKalanBilgi.TabIndex = 7;
            this.LblKalanBilgi.Text = "Kalan :";
            // 
            // LblKalan
            // 
            this.LblKalan.AutoSize = true;
            this.LblKalan.Location = new System.Drawing.Point(155, 210);
            this.LblKalan.Name = "LblKalan";
            this.LblKalan.Size = new System.Drawing.Size(28, 21);
            this.LblKalan.TabIndex = 8;
            this.LblKalan.Text = "00";
            // 
            // FrmBolmeKullanmadanIkiSayiyiBol
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 352);
            this.Controls.Add(this.LblKalan);
            this.Controls.Add(this.LblKalanBilgi);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.TxtSayiIki);
            this.Controls.Add(this.TxtSayiBir);
            this.Controls.Add(this.LblIkinciSayi);
            this.Controls.Add(this.LblBirinciSayi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmBolmeKullanmadanIkiSayiyiBol";
            this.Text = "FrmBolmeKullanmadanIkiSayiyiBol";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBirinciSayi;
        private System.Windows.Forms.Label LblIkinciSayi;
        private System.Windows.Forms.TextBox TxtSayiBir;
        private System.Windows.Forms.TextBox TxtSayiIki;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.Label LblSonuc;
        private System.Windows.Forms.Label LblKalanBilgi;
        private System.Windows.Forms.Label LblKalan;
    }
}

