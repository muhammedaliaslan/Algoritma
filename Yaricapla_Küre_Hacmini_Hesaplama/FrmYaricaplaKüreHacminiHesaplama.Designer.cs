namespace Yaricapla_Küre_Hacmini_Hesaplama
{
    partial class FrmYaricaplaKüreHacminiHesaplama
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
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.TxtSayiGiriniz = new System.Windows.Forms.TextBox();
            this.LblSayi = new System.Windows.Forms.Label();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(138, 72);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(137, 33);
            this.BtnHesapla.TabIndex = 8;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // TxtSayiGiriniz
            // 
            this.TxtSayiGiriniz.Location = new System.Drawing.Point(138, 28);
            this.TxtSayiGiriniz.Name = "TxtSayiGiriniz";
            this.TxtSayiGiriniz.Size = new System.Drawing.Size(137, 29);
            this.TxtSayiGiriniz.TabIndex = 7;
            // 
            // LblSayi
            // 
            this.LblSayi.AutoSize = true;
            this.LblSayi.Location = new System.Drawing.Point(16, 36);
            this.LblSayi.Name = "LblSayi";
            this.LblSayi.Size = new System.Drawing.Size(104, 21);
            this.LblSayi.TabIndex = 6;
            this.LblSayi.Text = "Sayı Giriniz :";
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(30, 134);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 9;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(101, 134);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 10;
            this.LblSonuc.Text = "0";
            // 
            // FrmYaricaplaKüreHacminiHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 232);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.TxtSayiGiriniz);
            this.Controls.Add(this.LblSayi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmYaricaplaKüreHacminiHesaplama";
            this.Text = "FrmYaricaplaKüreHacminiHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.TextBox TxtSayiGiriniz;
        private System.Windows.Forms.Label LblSayi;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.Label LblSonuc;
    }
}

