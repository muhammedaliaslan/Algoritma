namespace Carpma_Kullanmadan_Iki_Sayiyi_Carp
{
    partial class FrmCarpmaKullanmadanIkiSayiyiCarp
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
            this.LblSayiBir = new System.Windows.Forms.Label();
            this.LblSayiIki = new System.Windows.Forms.Label();
            this.TxtSayiBir = new System.Windows.Forms.TextBox();
            this.TxtSayiIki = new System.Windows.Forms.TextBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblSayiBir
            // 
            this.LblSayiBir.AutoSize = true;
            this.LblSayiBir.Location = new System.Drawing.Point(75, 43);
            this.LblSayiBir.Name = "LblSayiBir";
            this.LblSayiBir.Size = new System.Drawing.Size(63, 21);
            this.LblSayiBir.TabIndex = 0;
            this.LblSayiBir.Text = "1.Sayı :";
            // 
            // LblSayiIki
            // 
            this.LblSayiIki.AutoSize = true;
            this.LblSayiIki.Location = new System.Drawing.Point(75, 84);
            this.LblSayiIki.Name = "LblSayiIki";
            this.LblSayiIki.Size = new System.Drawing.Size(63, 21);
            this.LblSayiIki.TabIndex = 1;
            this.LblSayiIki.Text = "2.Sayı :";
            // 
            // TxtSayiBir
            // 
            this.TxtSayiBir.Location = new System.Drawing.Point(149, 39);
            this.TxtSayiBir.Name = "TxtSayiBir";
            this.TxtSayiBir.Size = new System.Drawing.Size(100, 29);
            this.TxtSayiBir.TabIndex = 2;
            // 
            // TxtSayiIki
            // 
            this.TxtSayiIki.Location = new System.Drawing.Point(149, 80);
            this.TxtSayiIki.Name = "TxtSayiIki";
            this.TxtSayiIki.Size = new System.Drawing.Size(100, 29);
            this.TxtSayiIki.TabIndex = 3;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(149, 133);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(100, 30);
            this.BtnYazdir.TabIndex = 4;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(75, 185);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 5;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(145, 185);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 6;
            this.LblSonuc.Text = "0";
            // 
            // FrmCarpmaKullanmadanIkiSayiyiCarp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 347);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.TxtSayiIki);
            this.Controls.Add(this.TxtSayiBir);
            this.Controls.Add(this.LblSayiIki);
            this.Controls.Add(this.LblSayiBir);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCarpmaKullanmadanIkiSayiyiCarp";
            this.Text = "FrmCarpmaKullanmadanIkiSayiyiCarp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSayiBir;
        private System.Windows.Forms.Label LblSayiIki;
        private System.Windows.Forms.TextBox TxtSayiBir;
        private System.Windows.Forms.TextBox TxtSayiIki;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.Label LblSonuc;
    }
}

