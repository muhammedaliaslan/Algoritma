namespace SayiAl_AdYazdir
{
    partial class FrmSayiAlAdYazdir
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
            this.LblAd = new System.Windows.Forms.Label();
            this.LblSayi = new System.Windows.Forms.Label();
            this.TxtAd = new System.Windows.Forms.TextBox();
            this.TxtSayi = new System.Windows.Forms.TextBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.LstSonuc = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblAd
            // 
            this.LblAd.AutoSize = true;
            this.LblAd.Location = new System.Drawing.Point(29, 66);
            this.LblAd.Name = "LblAd";
            this.LblAd.Size = new System.Drawing.Size(126, 21);
            this.LblAd.TabIndex = 0;
            this.LblAd.Text = "Adınızı Giriniz :";
            // 
            // LblSayi
            // 
            this.LblSayi.AutoSize = true;
            this.LblSayi.Location = new System.Drawing.Point(51, 124);
            this.LblSayi.Name = "LblSayi";
            this.LblSayi.Size = new System.Drawing.Size(104, 21);
            this.LblSayi.TabIndex = 1;
            this.LblSayi.Text = "Sayı Giriniz :";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(161, 62);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Size = new System.Drawing.Size(100, 29);
            this.TxtAd.TabIndex = 2;
            // 
            // TxtSayi
            // 
            this.TxtSayi.Location = new System.Drawing.Point(161, 120);
            this.TxtSayi.Name = "TxtSayi";
            this.TxtSayi.Size = new System.Drawing.Size(100, 29);
            this.TxtSayi.TabIndex = 3;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(161, 167);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(100, 28);
            this.BtnYazdir.TabIndex = 4;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // LstSonuc
            // 
            this.LstSonuc.FormattingEnabled = true;
            this.LstSonuc.ItemHeight = 21;
            this.LstSonuc.Location = new System.Drawing.Point(287, 28);
            this.LstSonuc.Name = "LstSonuc";
            this.LstSonuc.Size = new System.Drawing.Size(267, 235);
            this.LstSonuc.TabIndex = 5;
            // 
            // FrmSayiAlAdYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 357);
            this.Controls.Add(this.LstSonuc);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.TxtSayi);
            this.Controls.Add(this.TxtAd);
            this.Controls.Add(this.LblSayi);
            this.Controls.Add(this.LblAd);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSayiAlAdYazdir";
            this.Text = "FrmSayiAlAdYazdir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblAd;
        private System.Windows.Forms.Label LblSayi;
        private System.Windows.Forms.TextBox TxtAd;
        private System.Windows.Forms.TextBox TxtSayi;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.ListBox LstSonuc;
    }
}

