namespace Bolme_Islemi
{
    partial class FrmBolmeIslemi
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
            this.TxtBirinciSayi = new System.Windows.Forms.TextBox();
            this.TxtIkinciSayi = new System.Windows.Forms.TextBox();
            this.LblBirinciSayi = new System.Windows.Forms.Label();
            this.LblIkinciSayi = new System.Windows.Forms.Label();
            this.LblBolme = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.LblEsittir = new System.Windows.Forms.Label();
            this.TxtSonuc = new System.Windows.Forms.TextBox();
            this.LblKalan = new System.Windows.Forms.Label();
            this.TxtKalan = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtBirinciSayi
            // 
            this.TxtBirinciSayi.Location = new System.Drawing.Point(97, 76);
            this.TxtBirinciSayi.Name = "TxtBirinciSayi";
            this.TxtBirinciSayi.Size = new System.Drawing.Size(100, 34);
            this.TxtBirinciSayi.TabIndex = 0;
            // 
            // TxtIkinciSayi
            // 
            this.TxtIkinciSayi.Location = new System.Drawing.Point(290, 76);
            this.TxtIkinciSayi.Name = "TxtIkinciSayi";
            this.TxtIkinciSayi.Size = new System.Drawing.Size(100, 34);
            this.TxtIkinciSayi.TabIndex = 1;
            // 
            // LblBirinciSayi
            // 
            this.LblBirinciSayi.AutoSize = true;
            this.LblBirinciSayi.Location = new System.Drawing.Point(92, 29);
            this.LblBirinciSayi.Name = "LblBirinciSayi";
            this.LblBirinciSayi.Size = new System.Drawing.Size(68, 28);
            this.LblBirinciSayi.TabIndex = 2;
            this.LblBirinciSayi.Text = "1.Sayı";
            // 
            // LblIkinciSayi
            // 
            this.LblIkinciSayi.AutoSize = true;
            this.LblIkinciSayi.Location = new System.Drawing.Point(285, 29);
            this.LblIkinciSayi.Name = "LblIkinciSayi";
            this.LblIkinciSayi.Size = new System.Drawing.Size(68, 28);
            this.LblIkinciSayi.TabIndex = 3;
            this.LblIkinciSayi.Text = "2.Sayı";
            // 
            // LblBolme
            // 
            this.LblBolme.AutoSize = true;
            this.LblBolme.Location = new System.Drawing.Point(229, 82);
            this.LblBolme.Name = "LblBolme";
            this.LblBolme.Size = new System.Drawing.Size(21, 28);
            this.LblBolme.TabIndex = 4;
            this.LblBolme.Text = "/";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(165, 133);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(152, 36);
            this.BtnHesapla.TabIndex = 5;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // LblEsittir
            // 
            this.LblEsittir.AutoSize = true;
            this.LblEsittir.Location = new System.Drawing.Point(431, 79);
            this.LblEsittir.Name = "LblEsittir";
            this.LblEsittir.Size = new System.Drawing.Size(26, 28);
            this.LblEsittir.TabIndex = 6;
            this.LblEsittir.Text = "=";
            // 
            // TxtSonuc
            // 
            this.TxtSonuc.Enabled = false;
            this.TxtSonuc.Location = new System.Drawing.Point(524, 76);
            this.TxtSonuc.Name = "TxtSonuc";
            this.TxtSonuc.Size = new System.Drawing.Size(100, 34);
            this.TxtSonuc.TabIndex = 7;
            // 
            // LblKalan
            // 
            this.LblKalan.AutoSize = true;
            this.LblKalan.Location = new System.Drawing.Point(431, 137);
            this.LblKalan.Name = "LblKalan";
            this.LblKalan.Size = new System.Drawing.Size(85, 28);
            this.LblKalan.TabIndex = 8;
            this.LblKalan.Text = "Kalan =";
            // 
            // TxtKalan
            // 
            this.TxtKalan.Enabled = false;
            this.TxtKalan.Location = new System.Drawing.Point(524, 133);
            this.TxtKalan.Name = "TxtKalan";
            this.TxtKalan.Size = new System.Drawing.Size(100, 34);
            this.TxtKalan.TabIndex = 9;
            // 
            // FrmBolmeIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 515);
            this.Controls.Add(this.TxtKalan);
            this.Controls.Add(this.LblKalan);
            this.Controls.Add(this.TxtSonuc);
            this.Controls.Add(this.LblEsittir);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.LblBolme);
            this.Controls.Add(this.LblIkinciSayi);
            this.Controls.Add(this.LblBirinciSayi);
            this.Controls.Add(this.TxtIkinciSayi);
            this.Controls.Add(this.TxtBirinciSayi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBolmeIslemi";
            this.Text = "FrmBolmeIslemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtBirinciSayi;
        private System.Windows.Forms.TextBox TxtIkinciSayi;
        private System.Windows.Forms.Label LblBirinciSayi;
        private System.Windows.Forms.Label LblIkinciSayi;
        private System.Windows.Forms.Label LblBolme;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label LblEsittir;
        private System.Windows.Forms.TextBox TxtSonuc;
        private System.Windows.Forms.Label LblKalan;
        private System.Windows.Forms.TextBox TxtKalan;
    }
}

