namespace Buyuk_Sayi_Yazdirma
{
    partial class FrmBuyukSayiyiYazdirma
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
            this.label2 = new System.Windows.Forms.Label();
            this.TxtBirinciSayi = new System.Windows.Forms.TextBox();
            this.TxtIkinciSayi = new System.Windows.Forms.TextBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblBirinciSayi
            // 
            this.LblBirinciSayi.AutoSize = true;
            this.LblBirinciSayi.Location = new System.Drawing.Point(111, 74);
            this.LblBirinciSayi.Name = "LblBirinciSayi";
            this.LblBirinciSayi.Size = new System.Drawing.Size(63, 21);
            this.LblBirinciSayi.TabIndex = 0;
            this.LblBirinciSayi.Text = "1.Sayı :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "2.Sayı :";
            // 
            // TxtBirinciSayi
            // 
            this.TxtBirinciSayi.Location = new System.Drawing.Point(179, 66);
            this.TxtBirinciSayi.Name = "TxtBirinciSayi";
            this.TxtBirinciSayi.Size = new System.Drawing.Size(100, 29);
            this.TxtBirinciSayi.TabIndex = 2;
            // 
            // TxtIkinciSayi
            // 
            this.TxtIkinciSayi.Location = new System.Drawing.Point(179, 103);
            this.TxtIkinciSayi.Name = "TxtIkinciSayi";
            this.TxtIkinciSayi.Size = new System.Drawing.Size(100, 29);
            this.TxtIkinciSayi.TabIndex = 3;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(179, 151);
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
            this.LblSonucBilgi.Location = new System.Drawing.Point(399, 74);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 5;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(471, 74);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 6;
            this.LblSonuc.Text = "0";
            // 
            // FrmBuyukSayiyiYazdirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 444);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.TxtIkinciSayi);
            this.Controls.Add(this.TxtBirinciSayi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblBirinciSayi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmBuyukSayiyiYazdirma";
            this.Text = "FrmBuyukSayiyiYazdirma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBirinciSayi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtBirinciSayi;
        private System.Windows.Forms.TextBox TxtIkinciSayi;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.Label LblSonuc;
    }
}

