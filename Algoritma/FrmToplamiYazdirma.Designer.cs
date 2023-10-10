namespace Algoritma
{
    partial class FrmToplamiYazdirma
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
            this.TxtSayiBir = new System.Windows.Forms.TextBox();
            this.LblSayiBir = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.LblSayiIki = new System.Windows.Forms.Label();
            this.TxtSayiIki = new System.Windows.Forms.TextBox();
            this.LblArti = new System.Windows.Forms.Label();
            this.LblEsittir = new System.Windows.Forms.Label();
            this.TxtSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // TxtSayiBir
            // 
            this.TxtSayiBir.Location = new System.Drawing.Point(14, 42);
            this.TxtSayiBir.Name = "TxtSayiBir";
            this.TxtSayiBir.Size = new System.Drawing.Size(100, 29);
            this.TxtSayiBir.TabIndex = 0;
            // 
            // LblSayiBir
            // 
            this.LblSayiBir.AutoSize = true;
            this.LblSayiBir.Location = new System.Drawing.Point(37, 18);
            this.LblSayiBir.Name = "LblSayiBir";
            this.LblSayiBir.Size = new System.Drawing.Size(55, 21);
            this.LblSayiBir.TabIndex = 1;
            this.LblSayiBir.Text = "1.Sayı";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(108, 90);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(85, 28);
            this.BtnHesapla.TabIndex = 2;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // LblSayiIki
            // 
            this.LblSayiIki.AutoSize = true;
            this.LblSayiIki.Location = new System.Drawing.Point(220, 18);
            this.LblSayiIki.Name = "LblSayiIki";
            this.LblSayiIki.Size = new System.Drawing.Size(55, 21);
            this.LblSayiIki.TabIndex = 4;
            this.LblSayiIki.Text = "2.Sayi";
            // 
            // TxtSayiIki
            // 
            this.TxtSayiIki.Location = new System.Drawing.Point(197, 42);
            this.TxtSayiIki.Name = "TxtSayiIki";
            this.TxtSayiIki.Size = new System.Drawing.Size(100, 29);
            this.TxtSayiIki.TabIndex = 3;
            // 
            // LblArti
            // 
            this.LblArti.AutoSize = true;
            this.LblArti.Location = new System.Drawing.Point(141, 50);
            this.LblArti.Name = "LblArti";
            this.LblArti.Size = new System.Drawing.Size(21, 21);
            this.LblArti.TabIndex = 5;
            this.LblArti.Text = "+";
            // 
            // LblEsittir
            // 
            this.LblEsittir.AutoSize = true;
            this.LblEsittir.Location = new System.Drawing.Point(322, 50);
            this.LblEsittir.Name = "LblEsittir";
            this.LblEsittir.Size = new System.Drawing.Size(21, 21);
            this.LblEsittir.TabIndex = 6;
            this.LblEsittir.Text = "=";
            // 
            // TxtSonuc
            // 
            this.TxtSonuc.Location = new System.Drawing.Point(366, 42);
            this.TxtSonuc.Name = "TxtSonuc";
            this.TxtSonuc.Size = new System.Drawing.Size(100, 29);
            this.TxtSonuc.TabIndex = 7;
            // 
            // FrmToplamiYazdirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 221);
            this.Controls.Add(this.TxtSonuc);
            this.Controls.Add(this.LblEsittir);
            this.Controls.Add(this.LblArti);
            this.Controls.Add(this.LblSayiIki);
            this.Controls.Add(this.TxtSayiIki);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.LblSayiBir);
            this.Controls.Add(this.TxtSayiBir);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmToplamiYazdirma";
            this.Text = "FrmToplamiYazdirma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSayiBir;
        private System.Windows.Forms.Label LblSayiBir;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label LblSayiIki;
        private System.Windows.Forms.TextBox TxtSayiIki;
        private System.Windows.Forms.Label LblArti;
        private System.Windows.Forms.Label LblEsittir;
        private System.Windows.Forms.TextBox TxtSonuc;
    }
}

