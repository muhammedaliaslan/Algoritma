namespace Carpma_Islemi
{
    partial class FrmCarpmaIslemi
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
            this.LblYildiz = new System.Windows.Forms.Label();
            this.LblEsittir = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.TxtSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LblSayiBir
            // 
            this.LblSayiBir.AutoSize = true;
            this.LblSayiBir.Location = new System.Drawing.Point(77, 77);
            this.LblSayiBir.Name = "LblSayiBir";
            this.LblSayiBir.Size = new System.Drawing.Size(55, 21);
            this.LblSayiBir.TabIndex = 0;
            this.LblSayiBir.Text = "1.Sayı";
            // 
            // LblSayiIki
            // 
            this.LblSayiIki.AutoSize = true;
            this.LblSayiIki.Location = new System.Drawing.Point(291, 77);
            this.LblSayiIki.Name = "LblSayiIki";
            this.LblSayiIki.Size = new System.Drawing.Size(55, 21);
            this.LblSayiIki.TabIndex = 1;
            this.LblSayiIki.Text = "2.Sayı";
            // 
            // TxtSayiBir
            // 
            this.TxtSayiBir.Location = new System.Drawing.Point(77, 106);
            this.TxtSayiBir.Name = "TxtSayiBir";
            this.TxtSayiBir.Size = new System.Drawing.Size(111, 29);
            this.TxtSayiBir.TabIndex = 2;
            // 
            // TxtSayiIki
            // 
            this.TxtSayiIki.Location = new System.Drawing.Point(291, 106);
            this.TxtSayiIki.Name = "TxtSayiIki";
            this.TxtSayiIki.Size = new System.Drawing.Size(111, 29);
            this.TxtSayiIki.TabIndex = 3;
            // 
            // LblYildiz
            // 
            this.LblYildiz.AutoSize = true;
            this.LblYildiz.Location = new System.Drawing.Point(229, 110);
            this.LblYildiz.Name = "LblYildiz";
            this.LblYildiz.Size = new System.Drawing.Size(17, 21);
            this.LblYildiz.TabIndex = 4;
            this.LblYildiz.Text = "*";
            // 
            // LblEsittir
            // 
            this.LblEsittir.AutoSize = true;
            this.LblEsittir.Location = new System.Drawing.Point(420, 110);
            this.LblEsittir.Name = "LblEsittir";
            this.LblEsittir.Size = new System.Drawing.Size(21, 21);
            this.LblEsittir.TabIndex = 5;
            this.LblEsittir.Text = "=";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(189, 154);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(97, 33);
            this.BtnHesapla.TabIndex = 6;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // TxtSonuc
            // 
            this.TxtSonuc.Location = new System.Drawing.Point(462, 106);
            this.TxtSonuc.Name = "TxtSonuc";
            this.TxtSonuc.Size = new System.Drawing.Size(111, 29);
            this.TxtSonuc.TabIndex = 7;
            // 
            // FrmCarpmaIslemi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(702, 450);
            this.Controls.Add(this.TxtSonuc);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.LblEsittir);
            this.Controls.Add(this.LblYildiz);
            this.Controls.Add(this.TxtSayiIki);
            this.Controls.Add(this.TxtSayiBir);
            this.Controls.Add(this.LblSayiIki);
            this.Controls.Add(this.LblSayiBir);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmCarpmaIslemi";
            this.Text = "FrmCarpmaIslemi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSayiBir;
        private System.Windows.Forms.Label LblSayiIki;
        private System.Windows.Forms.TextBox TxtSayiBir;
        private System.Windows.Forms.TextBox TxtSayiIki;
        private System.Windows.Forms.Label LblYildiz;
        private System.Windows.Forms.Label LblEsittir;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.TextBox TxtSonuc;
    }
}

