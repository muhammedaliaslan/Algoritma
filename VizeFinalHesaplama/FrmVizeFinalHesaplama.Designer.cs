namespace VizeFinalHesaplama
{
    partial class FrmVizeFinalHesaplama
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
            this.txtFinalNotu = new System.Windows.Forms.TextBox();
            this.txtVizeNotu = new System.Windows.Forms.TextBox();
            this.lblFinalNot = new System.Windows.Forms.Label();
            this.lblVizeNot = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.lblDurumBilgi = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(577, 12);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(19, 21);
            this.lblSonuc.TabIndex = 13;
            this.lblSonuc.Text = "0";
            // 
            // lblSonucBilgi
            // 
            this.lblSonucBilgi.AutoSize = true;
            this.lblSonucBilgi.Location = new System.Drawing.Point(501, 12);
            this.lblSonucBilgi.Name = "lblSonucBilgi";
            this.lblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.lblSonucBilgi.TabIndex = 12;
            this.lblSonucBilgi.Text = "Sonuç :";
            // 
            // txtFinalNotu
            // 
            this.txtFinalNotu.Location = new System.Drawing.Point(53, 106);
            this.txtFinalNotu.Name = "txtFinalNotu";
            this.txtFinalNotu.Size = new System.Drawing.Size(144, 29);
            this.txtFinalNotu.TabIndex = 11;
            // 
            // txtVizeNotu
            // 
            this.txtVizeNotu.Location = new System.Drawing.Point(53, 35);
            this.txtVizeNotu.Name = "txtVizeNotu";
            this.txtVizeNotu.Size = new System.Drawing.Size(144, 29);
            this.txtVizeNotu.TabIndex = 10;
            // 
            // lblFinalNot
            // 
            this.lblFinalNot.AutoSize = true;
            this.lblFinalNot.Location = new System.Drawing.Point(49, 82);
            this.lblFinalNot.Name = "lblFinalNot";
            this.lblFinalNot.Size = new System.Drawing.Size(152, 21);
            this.lblFinalNot.TabIndex = 9;
            this.lblFinalNot.Text = "Final Notu Giriniz :";
            // 
            // lblVizeNot
            // 
            this.lblVizeNot.AutoSize = true;
            this.lblVizeNot.Location = new System.Drawing.Point(51, 11);
            this.lblVizeNot.Name = "lblVizeNot";
            this.lblVizeNot.Size = new System.Drawing.Size(148, 21);
            this.lblVizeNot.TabIndex = 8;
            this.lblVizeNot.Text = "Vize Notu Giriniz :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(53, 154);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(144, 30);
            this.btnHesapla.TabIndex = 14;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // lblDurumBilgi
            // 
            this.lblDurumBilgi.AutoSize = true;
            this.lblDurumBilgi.Location = new System.Drawing.Point(495, 43);
            this.lblDurumBilgi.Name = "lblDurumBilgi";
            this.lblDurumBilgi.Size = new System.Drawing.Size(71, 21);
            this.lblDurumBilgi.TabIndex = 15;
            this.lblDurumBilgi.Text = "Durum :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(577, 43);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(19, 21);
            this.lblDurum.TabIndex = 16;
            this.lblDurum.Text = "0";
            // 
            // FrmVizeFinalHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 417);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblDurumBilgi);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSonucBilgi);
            this.Controls.Add(this.txtFinalNotu);
            this.Controls.Add(this.txtVizeNotu);
            this.Controls.Add(this.lblFinalNot);
            this.Controls.Add(this.lblVizeNot);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmVizeFinalHesaplama";
            this.Text = "FrmVizeFinalHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSonucBilgi;
        private System.Windows.Forms.TextBox txtFinalNotu;
        private System.Windows.Forms.TextBox txtVizeNotu;
        private System.Windows.Forms.Label lblFinalNot;
        private System.Windows.Forms.Label lblVizeNot;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label lblDurumBilgi;
        private System.Windows.Forms.Label lblDurum;
    }
}

