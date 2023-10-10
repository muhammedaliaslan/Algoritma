namespace IkiSayiAl_TekYazdir
{
    partial class FrmIkiSayiAlTekYazdir
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
            this.LstYazdirilanSayilar = new System.Windows.Forms.ListBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.TxtSayiIki = new System.Windows.Forms.TextBox();
            this.LblSayiIki = new System.Windows.Forms.Label();
            this.LblSayiBir = new System.Windows.Forms.Label();
            this.TxtSayiBir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // LstYazdirilanSayilar
            // 
            this.LstYazdirilanSayilar.FormattingEnabled = true;
            this.LstYazdirilanSayilar.ItemHeight = 21;
            this.LstYazdirilanSayilar.Location = new System.Drawing.Point(278, 49);
            this.LstYazdirilanSayilar.Name = "LstYazdirilanSayilar";
            this.LstYazdirilanSayilar.Size = new System.Drawing.Size(273, 256);
            this.LstYazdirilanSayilar.TabIndex = 17;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(105, 153);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(100, 30);
            this.BtnYazdir.TabIndex = 16;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // TxtSayiIki
            // 
            this.TxtSayiIki.Location = new System.Drawing.Point(105, 94);
            this.TxtSayiIki.Name = "TxtSayiIki";
            this.TxtSayiIki.Size = new System.Drawing.Size(100, 29);
            this.TxtSayiIki.TabIndex = 15;
            // 
            // LblSayiIki
            // 
            this.LblSayiIki.AutoSize = true;
            this.LblSayiIki.Location = new System.Drawing.Point(21, 94);
            this.LblSayiIki.Name = "LblSayiIki";
            this.LblSayiIki.Size = new System.Drawing.Size(67, 21);
            this.LblSayiIki.TabIndex = 14;
            this.LblSayiIki.Text = "2. Sayı :";
            // 
            // LblSayiBir
            // 
            this.LblSayiBir.AutoSize = true;
            this.LblSayiBir.Location = new System.Drawing.Point(21, 49);
            this.LblSayiBir.Name = "LblSayiBir";
            this.LblSayiBir.Size = new System.Drawing.Size(67, 21);
            this.LblSayiBir.TabIndex = 13;
            this.LblSayiBir.Text = "1. Sayı :";
            // 
            // TxtSayiBir
            // 
            this.TxtSayiBir.Location = new System.Drawing.Point(105, 41);
            this.TxtSayiBir.Name = "TxtSayiBir";
            this.TxtSayiBir.Size = new System.Drawing.Size(100, 29);
            this.TxtSayiBir.TabIndex = 12;
            // 
            // FrmIkiSayiAlTekYazdir
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 433);
            this.Controls.Add(this.LstYazdirilanSayilar);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.TxtSayiIki);
            this.Controls.Add(this.LblSayiIki);
            this.Controls.Add(this.LblSayiBir);
            this.Controls.Add(this.TxtSayiBir);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmIkiSayiAlTekYazdir";
            this.Text = "FrmIkiSayiAlTekYazdir";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox LstYazdirilanSayilar;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.TextBox TxtSayiIki;
        private System.Windows.Forms.Label LblSayiIki;
        private System.Windows.Forms.Label LblSayiBir;
        private System.Windows.Forms.TextBox TxtSayiBir;
    }
}

