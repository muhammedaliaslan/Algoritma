namespace KullanicidanIkiSayiAlUssuYaz
{
    partial class FrmKullanicidanIkiSayiAlUssuYaz
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
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.lblEsittir = new System.Windows.Forms.Label();
            this.lblSayiIki = new System.Windows.Forms.Label();
            this.txtSayiIki = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblSayiBir = new System.Windows.Forms.Label();
            this.txtSayiBir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtSonuc
            // 
            this.txtSonuc.Location = new System.Drawing.Point(354, 105);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(100, 34);
            this.txtSonuc.TabIndex = 15;
            // 
            // lblEsittir
            // 
            this.lblEsittir.AutoSize = true;
            this.lblEsittir.Location = new System.Drawing.Point(310, 108);
            this.lblEsittir.Name = "lblEsittir";
            this.lblEsittir.Size = new System.Drawing.Size(26, 28);
            this.lblEsittir.TabIndex = 14;
            this.lblEsittir.Text = "=";
            // 
            // lblSayiIki
            // 
            this.lblSayiIki.AutoSize = true;
            this.lblSayiIki.Location = new System.Drawing.Point(185, 62);
            this.lblSayiIki.Name = "lblSayiIki";
            this.lblSayiIki.Size = new System.Drawing.Size(68, 28);
            this.lblSayiIki.TabIndex = 12;
            this.lblSayiIki.Text = "2.Sayi";
            // 
            // txtSayiIki
            // 
            this.txtSayiIki.Location = new System.Drawing.Point(185, 105);
            this.txtSayiIki.Name = "txtSayiIki";
            this.txtSayiIki.Size = new System.Drawing.Size(100, 34);
            this.txtSayiIki.TabIndex = 11;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(354, 155);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(100, 37);
            this.btnHesapla.TabIndex = 10;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // lblSayiBir
            // 
            this.lblSayiBir.AutoSize = true;
            this.lblSayiBir.Location = new System.Drawing.Point(60, 62);
            this.lblSayiBir.Name = "lblSayiBir";
            this.lblSayiBir.Size = new System.Drawing.Size(68, 28);
            this.lblSayiBir.TabIndex = 9;
            this.lblSayiBir.Text = "1.Sayı";
            // 
            // txtSayiBir
            // 
            this.txtSayiBir.Location = new System.Drawing.Point(60, 105);
            this.txtSayiBir.Name = "txtSayiBir";
            this.txtSayiBir.Size = new System.Drawing.Size(100, 34);
            this.txtSayiBir.TabIndex = 8;
            // 
            // FrmKullanicidanIkiSayiAlUssuYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 527);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.lblEsittir);
            this.Controls.Add(this.lblSayiIki);
            this.Controls.Add(this.txtSayiIki);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSayiBir);
            this.Controls.Add(this.txtSayiBir);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKullanicidanIkiSayiAlUssuYaz";
            this.Text = "FrmKullanicidanIkiSayiAlUssuYaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSonuc;
        private System.Windows.Forms.Label lblEsittir;
        private System.Windows.Forms.Label lblSayiIki;
        private System.Windows.Forms.TextBox txtSayiIki;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblSayiBir;
        private System.Windows.Forms.TextBox txtSayiBir;
    }
}

