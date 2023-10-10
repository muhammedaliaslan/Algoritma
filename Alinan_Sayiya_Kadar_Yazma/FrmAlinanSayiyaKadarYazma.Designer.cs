namespace Alinan_Sayiya_Kadar_Yazma
{
    partial class FrmAlinanSayiyaKadarYazma
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
            this.LstSonuc = new System.Windows.Forms.ListBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.TxtSayiAl = new System.Windows.Forms.TextBox();
            this.LblSayiGir = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LstSonuc
            // 
            this.LstSonuc.FormattingEnabled = true;
            this.LstSonuc.ItemHeight = 21;
            this.LstSonuc.Location = new System.Drawing.Point(246, 87);
            this.LstSonuc.Name = "LstSonuc";
            this.LstSonuc.Size = new System.Drawing.Size(177, 193);
            this.LstSonuc.TabIndex = 0;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(122, 119);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(100, 28);
            this.BtnYazdir.TabIndex = 1;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // TxtSayiAl
            // 
            this.TxtSayiAl.Location = new System.Drawing.Point(122, 84);
            this.TxtSayiAl.Name = "TxtSayiAl";
            this.TxtSayiAl.Size = new System.Drawing.Size(100, 29);
            this.TxtSayiAl.TabIndex = 2;
            // 
            // LblSayiGir
            // 
            this.LblSayiGir.AutoSize = true;
            this.LblSayiGir.Location = new System.Drawing.Point(12, 87);
            this.LblSayiGir.Name = "LblSayiGir";
            this.LblSayiGir.Size = new System.Drawing.Size(104, 21);
            this.LblSayiGir.TabIndex = 3;
            this.LblSayiGir.Text = "Sayı Giriniz :";
            // 
            // FrmAlinanSayiyaKadarYazma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(565, 423);
            this.Controls.Add(this.LblSayiGir);
            this.Controls.Add(this.TxtSayiAl);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.LstSonuc);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmAlinanSayiyaKadarYazma";
            this.Text = "FrmAlinanSayiyaKadarYazma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstSonuc;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.TextBox TxtSayiAl;
        private System.Windows.Forms.Label LblSayiGir;
    }
}

