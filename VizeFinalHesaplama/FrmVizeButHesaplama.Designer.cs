namespace VizeFinalHesaplama
{
    partial class FrmVizeButHesaplama
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
            this.txtButNot = new System.Windows.Forms.TextBox();
            this.lblButNot = new System.Windows.Forms.Label();
            this.txtVizeNotu = new System.Windows.Forms.TextBox();
            this.lblVizeNot = new System.Windows.Forms.Label();
            this.lblDurum = new System.Windows.Forms.Label();
            this.lblDurumBilgi = new System.Windows.Forms.Label();
            this.lblSonuc = new System.Windows.Forms.Label();
            this.lblSonucBilgi = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtButNot
            // 
            this.txtButNot.Location = new System.Drawing.Point(34, 114);
            this.txtButNot.Name = "txtButNot";
            this.txtButNot.Size = new System.Drawing.Size(144, 29);
            this.txtButNot.TabIndex = 22;
            // 
            // lblButNot
            // 
            this.lblButNot.AutoSize = true;
            this.lblButNot.Location = new System.Drawing.Point(36, 90);
            this.lblButNot.Name = "lblButNot";
            this.lblButNot.Size = new System.Drawing.Size(141, 21);
            this.lblButNot.TabIndex = 21;
            this.lblButNot.Text = "Büt Notu Giriniz :";
            // 
            // txtVizeNotu
            // 
            this.txtVizeNotu.Location = new System.Drawing.Point(34, 58);
            this.txtVizeNotu.Name = "txtVizeNotu";
            this.txtVizeNotu.Size = new System.Drawing.Size(144, 29);
            this.txtVizeNotu.TabIndex = 20;
            // 
            // lblVizeNot
            // 
            this.lblVizeNot.AutoSize = true;
            this.lblVizeNot.Location = new System.Drawing.Point(32, 34);
            this.lblVizeNot.Name = "lblVizeNot";
            this.lblVizeNot.Size = new System.Drawing.Size(148, 21);
            this.lblVizeNot.TabIndex = 19;
            this.lblVizeNot.Text = "Vize Notu Giriniz :";
            // 
            // lblDurum
            // 
            this.lblDurum.AutoSize = true;
            this.lblDurum.Location = new System.Drawing.Point(424, 66);
            this.lblDurum.Name = "lblDurum";
            this.lblDurum.Size = new System.Drawing.Size(19, 21);
            this.lblDurum.TabIndex = 26;
            this.lblDurum.Text = "0";
            // 
            // lblDurumBilgi
            // 
            this.lblDurumBilgi.AutoSize = true;
            this.lblDurumBilgi.Location = new System.Drawing.Point(342, 66);
            this.lblDurumBilgi.Name = "lblDurumBilgi";
            this.lblDurumBilgi.Size = new System.Drawing.Size(71, 21);
            this.lblDurumBilgi.TabIndex = 25;
            this.lblDurumBilgi.Text = "Durum :";
            // 
            // lblSonuc
            // 
            this.lblSonuc.AutoSize = true;
            this.lblSonuc.Location = new System.Drawing.Point(424, 35);
            this.lblSonuc.Name = "lblSonuc";
            this.lblSonuc.Size = new System.Drawing.Size(19, 21);
            this.lblSonuc.TabIndex = 24;
            this.lblSonuc.Text = "0";
            // 
            // lblSonucBilgi
            // 
            this.lblSonucBilgi.AutoSize = true;
            this.lblSonucBilgi.Location = new System.Drawing.Point(348, 35);
            this.lblSonucBilgi.Name = "lblSonucBilgi";
            this.lblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.lblSonucBilgi.TabIndex = 23;
            this.lblSonucBilgi.Text = "Sonuç :";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(33, 158);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(144, 30);
            this.btnHesapla.TabIndex = 27;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // FrmVizeButHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 492);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblDurum);
            this.Controls.Add(this.lblDurumBilgi);
            this.Controls.Add(this.lblSonuc);
            this.Controls.Add(this.lblSonucBilgi);
            this.Controls.Add(this.txtButNot);
            this.Controls.Add(this.lblButNot);
            this.Controls.Add(this.txtVizeNotu);
            this.Controls.Add(this.lblVizeNot);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmVizeButHesaplama";
            this.Text = "FrmVizeButHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtButNot;
        private System.Windows.Forms.Label lblButNot;
        private System.Windows.Forms.TextBox txtVizeNotu;
        private System.Windows.Forms.Label lblVizeNot;
        private System.Windows.Forms.Label lblDurum;
        private System.Windows.Forms.Label lblDurumBilgi;
        private System.Windows.Forms.Label lblSonuc;
        private System.Windows.Forms.Label lblSonucBilgi;
        private System.Windows.Forms.Button btnHesapla;
    }
}