namespace KullanicidanIkiSayiAlCiftSayilariBuyuktenKucugeYaz
{
    partial class FrmKullanicidanIkiSayiAlCiftSayilariBuyuktenKucugeYaz
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
            this.lstYazdirilanSayilar = new System.Windows.Forms.ListBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.txtSayiIki = new System.Windows.Forms.TextBox();
            this.lblSayiIki = new System.Windows.Forms.Label();
            this.lblSayiBir = new System.Windows.Forms.Label();
            this.txtSayiBir = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lstYazdirilanSayilar
            // 
            this.lstYazdirilanSayilar.FormattingEnabled = true;
            this.lstYazdirilanSayilar.ItemHeight = 28;
            this.lstYazdirilanSayilar.Location = new System.Drawing.Point(293, 51);
            this.lstYazdirilanSayilar.Name = "lstYazdirilanSayilar";
            this.lstYazdirilanSayilar.Size = new System.Drawing.Size(273, 256);
            this.lstYazdirilanSayilar.TabIndex = 17;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(121, 150);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(138, 41);
            this.btnYazdir.TabIndex = 16;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // txtSayiIki
            // 
            this.txtSayiIki.Location = new System.Drawing.Point(121, 96);
            this.txtSayiIki.Name = "txtSayiIki";
            this.txtSayiIki.Size = new System.Drawing.Size(138, 34);
            this.txtSayiIki.TabIndex = 15;
            // 
            // lblSayiIki
            // 
            this.lblSayiIki.AutoSize = true;
            this.lblSayiIki.Location = new System.Drawing.Point(30, 96);
            this.lblSayiIki.Name = "lblSayiIki";
            this.lblSayiIki.Size = new System.Drawing.Size(85, 28);
            this.lblSayiIki.TabIndex = 14;
            this.lblSayiIki.Text = "2. Sayı :";
            // 
            // lblSayiBir
            // 
            this.lblSayiBir.AutoSize = true;
            this.lblSayiBir.Location = new System.Drawing.Point(30, 51);
            this.lblSayiBir.Name = "lblSayiBir";
            this.lblSayiBir.Size = new System.Drawing.Size(85, 28);
            this.lblSayiBir.TabIndex = 13;
            this.lblSayiBir.Text = "1. Sayı :";
            // 
            // txtSayiBir
            // 
            this.txtSayiBir.Location = new System.Drawing.Point(121, 43);
            this.txtSayiBir.Name = "txtSayiBir";
            this.txtSayiBir.Size = new System.Drawing.Size(138, 34);
            this.txtSayiBir.TabIndex = 12;
            // 
            // FrmKullanicidanIkiSayiAlCiftSayilariBuyuktenKucugeYaz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(881, 501);
            this.Controls.Add(this.lstYazdirilanSayilar);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtSayiIki);
            this.Controls.Add(this.lblSayiIki);
            this.Controls.Add(this.lblSayiBir);
            this.Controls.Add(this.txtSayiBir);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKullanicidanIkiSayiAlCiftSayilariBuyuktenKucugeYaz";
            this.Text = "FrmKullanicidanIkiSayiAlCiftSayilariBuyuktenKucugeYaz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstYazdirilanSayilar;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.TextBox txtSayiIki;
        private System.Windows.Forms.Label lblSayiIki;
        private System.Windows.Forms.Label lblSayiBir;
        private System.Windows.Forms.TextBox txtSayiBir;
    }
}

