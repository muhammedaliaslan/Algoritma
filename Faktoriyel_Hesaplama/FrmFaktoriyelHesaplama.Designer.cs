namespace Faktoriyel_Hesaplama
{
    partial class FrmFaktoriyelHesaplama
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
            this.TxtSayi = new System.Windows.Forms.TextBox();
            this.LblSayiGiriniz = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtSayi
            // 
            this.TxtSayi.Location = new System.Drawing.Point(122, 48);
            this.TxtSayi.Name = "TxtSayi";
            this.TxtSayi.Size = new System.Drawing.Size(100, 29);
            this.TxtSayi.TabIndex = 0;
            // 
            // LblSayiGiriniz
            // 
            this.LblSayiGiriniz.AutoSize = true;
            this.LblSayiGiriniz.Location = new System.Drawing.Point(12, 56);
            this.LblSayiGiriniz.Name = "LblSayiGiriniz";
            this.LblSayiGiriniz.Size = new System.Drawing.Size(104, 21);
            this.LblSayiGiriniz.TabIndex = 1;
            this.LblSayiGiriniz.Text = "Sayı Giriniz :";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(122, 96);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(100, 34);
            this.BtnHesapla.TabIndex = 2;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(246, 51);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 3;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(317, 51);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 4;
            this.LblSonuc.Text = "0";
            // 
            // FrmFaktoriyelHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 333);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.LblSayiGiriniz);
            this.Controls.Add(this.TxtSayi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmFaktoriyelHesaplama";
            this.Text = "FrmFaktoriyelHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSayi;
        private System.Windows.Forms.Label LblSayiGiriniz;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.Label LblSonuc;
    }
}

