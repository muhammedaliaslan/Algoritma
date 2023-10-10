namespace YuzSayiAlIkiVeUcunKatıOlanlarinOrtalamasiniYaz
{
    partial class FrmYuzSayiAlIkiVeUcunKatıOlanlarinOrtalamasiniYaz
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
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblSonucBilgi = new System.Windows.Forms.Label();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lstEklenenSayilar = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.txtEklenenSayilar = new System.Windows.Forms.TextBox();
            this.lblSayiEkle = new System.Windows.Forms.Label();
            this.lstKatlar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(436, 335);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(19, 21);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "0";
            // 
            // lblSonucBilgi
            // 
            this.lblSonucBilgi.AutoSize = true;
            this.lblSonucBilgi.Location = new System.Drawing.Point(365, 335);
            this.lblSonucBilgi.Name = "lblSonucBilgi";
            this.lblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.lblSonucBilgi.TabIndex = 12;
            this.lblSonucBilgi.Text = "Sonuç :";
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(365, 286);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(220, 31);
            this.btnYazdir.TabIndex = 11;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lstEklenenSayilar
            // 
            this.lstEklenenSayilar.FormattingEnabled = true;
            this.lstEklenenSayilar.ItemHeight = 21;
            this.lstEklenenSayilar.Location = new System.Drawing.Point(47, 87);
            this.lstEklenenSayilar.Name = "lstEklenenSayilar";
            this.lstEklenenSayilar.Size = new System.Drawing.Size(220, 193);
            this.lstEklenenSayilar.TabIndex = 10;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(47, 50);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(220, 31);
            this.btnEkle.TabIndex = 9;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // txtEklenenSayilar
            // 
            this.txtEklenenSayilar.Location = new System.Drawing.Point(135, 15);
            this.txtEklenenSayilar.Name = "txtEklenenSayilar";
            this.txtEklenenSayilar.Size = new System.Drawing.Size(132, 29);
            this.txtEklenenSayilar.TabIndex = 8;
            // 
            // lblSayiEkle
            // 
            this.lblSayiEkle.AutoSize = true;
            this.lblSayiEkle.Location = new System.Drawing.Point(43, 18);
            this.lblSayiEkle.Name = "lblSayiEkle";
            this.lblSayiEkle.Size = new System.Drawing.Size(86, 21);
            this.lblSayiEkle.TabIndex = 7;
            this.lblSayiEkle.Text = "Sayı Ekle :";
            // 
            // lstKatlar
            // 
            this.lstKatlar.FormattingEnabled = true;
            this.lstKatlar.ItemHeight = 21;
            this.lstKatlar.Location = new System.Drawing.Point(365, 87);
            this.lstKatlar.Name = "lstKatlar";
            this.lstKatlar.Size = new System.Drawing.Size(220, 193);
            this.lstKatlar.TabIndex = 14;
            // 
            // FrmYuzSayiAlIkiVeUcunKatıOlanlarinOrtalamasiniYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 434);
            this.Controls.Add(this.lstKatlar);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSonucBilgi);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.lstEklenenSayilar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtEklenenSayilar);
            this.Controls.Add(this.lblSayiEkle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmYuzSayiAlIkiVeUcunKatıOlanlarinOrtalamasiniYaz";
            this.Text = "FrmYuzSayiAlIkiVeUcunKatıOlanlarinOrtalamasiniYaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSonucBilgi;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ListBox lstEklenenSayilar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.TextBox txtEklenenSayilar;
        private System.Windows.Forms.Label lblSayiEkle;
        private System.Windows.Forms.ListBox lstKatlar;
    }
}

