namespace KullanicidanYirmiTaneDogumTarihiAlYasOrtalamasiHesapla
{
    partial class FrmKullanicidanYirmiTaneDogumTarihiAlYasOrtalamasiHesapla
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
            this.btnYasEkle = new System.Windows.Forms.Button();
            this.lblYasiniziGiriniz = new System.Windows.Forms.Label();
            this.dtmTarihSec = new System.Windows.Forms.DateTimePicker();
            this.lstYaslar = new System.Windows.Forms.ListBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblOrtalama = new System.Windows.Forms.Label();
            this.lblOrtalamaBilgi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYasEkle
            // 
            this.btnYasEkle.Location = new System.Drawing.Point(50, 100);
            this.btnYasEkle.Name = "btnYasEkle";
            this.btnYasEkle.Size = new System.Drawing.Size(323, 40);
            this.btnYasEkle.TabIndex = 7;
            this.btnYasEkle.Text = "Yaş Ekle";
            this.btnYasEkle.UseVisualStyleBackColor = true;
            this.btnYasEkle.Click += new System.EventHandler(this.btnYasEkle_Click);
            // 
            // lblYasiniziGiriniz
            // 
            this.lblYasiniziGiriniz.AutoSize = true;
            this.lblYasiniziGiriniz.Location = new System.Drawing.Point(131, 18);
            this.lblYasiniziGiriniz.Name = "lblYasiniziGiriniz";
            this.lblYasiniziGiriniz.Size = new System.Drawing.Size(161, 28);
            this.lblYasiniziGiriniz.TabIndex = 6;
            this.lblYasiniziGiriniz.Text = "Yaşınızı Giriniz :";
            // 
            // dtmTarihSec
            // 
            this.dtmTarihSec.Location = new System.Drawing.Point(50, 53);
            this.dtmTarihSec.Name = "dtmTarihSec";
            this.dtmTarihSec.Size = new System.Drawing.Size(323, 34);
            this.dtmTarihSec.TabIndex = 5;
            // 
            // lstYaslar
            // 
            this.lstYaslar.FormattingEnabled = true;
            this.lstYaslar.ItemHeight = 28;
            this.lstYaslar.Location = new System.Drawing.Point(50, 154);
            this.lstYaslar.Name = "lstYaslar";
            this.lstYaslar.Size = new System.Drawing.Size(323, 368);
            this.lstYaslar.TabIndex = 8;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(50, 528);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(323, 65);
            this.btnHesapla.TabIndex = 9;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblOrtalama
            // 
            this.lblOrtalama.AutoSize = true;
            this.lblOrtalama.Location = new System.Drawing.Point(649, 56);
            this.lblOrtalama.Name = "lblOrtalama";
            this.lblOrtalama.Size = new System.Drawing.Size(24, 28);
            this.lblOrtalama.TabIndex = 11;
            this.lblOrtalama.Text = "0";
            // 
            // lblOrtalamaBilgi
            // 
            this.lblOrtalamaBilgi.AutoSize = true;
            this.lblOrtalamaBilgi.Location = new System.Drawing.Point(464, 56);
            this.lblOrtalamaBilgi.Name = "lblOrtalamaBilgi";
            this.lblOrtalamaBilgi.Size = new System.Drawing.Size(169, 28);
            this.lblOrtalamaBilgi.TabIndex = 10;
            this.lblOrtalamaBilgi.Text = "Yaş Ortalaması  :";
            // 
            // FrmKullanicidanYirmiTaneDogumTarihiAlYasOrtalamasiHesapla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 626);
            this.Controls.Add(this.lblOrtalama);
            this.Controls.Add(this.lblOrtalamaBilgi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lstYaslar);
            this.Controls.Add(this.btnYasEkle);
            this.Controls.Add(this.lblYasiniziGiriniz);
            this.Controls.Add(this.dtmTarihSec);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKullanicidanYirmiTaneDogumTarihiAlYasOrtalamasiHesapla";
            this.Text = "KullanicidanYirmiTaneDogumTarihiAlYasOrtalamasiHesapla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYasEkle;
        private System.Windows.Forms.Label lblYasiniziGiriniz;
        private System.Windows.Forms.DateTimePicker dtmTarihSec;
        private System.Windows.Forms.ListBox lstYaslar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblOrtalama;
        private System.Windows.Forms.Label lblOrtalamaBilgi;
    }
}

