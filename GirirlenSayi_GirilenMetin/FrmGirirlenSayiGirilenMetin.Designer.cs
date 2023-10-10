namespace GirirlenSayi_GirilenMetin
{
    partial class FrmGirirlenSayiGirilenMetin
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
            this.LblMetinGiriniz = new System.Windows.Forms.Label();
            this.LblSayiGiriniz = new System.Windows.Forms.Label();
            this.TxtGirilenMetin = new System.Windows.Forms.TextBox();
            this.TxtGirilenSayi = new System.Windows.Forms.TextBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.LstYazdirilanMetinler = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // LblMetinGiriniz
            // 
            this.LblMetinGiriniz.AutoSize = true;
            this.LblMetinGiriniz.Location = new System.Drawing.Point(41, 54);
            this.LblMetinGiriniz.Name = "LblMetinGiriniz";
            this.LblMetinGiriniz.Size = new System.Drawing.Size(117, 21);
            this.LblMetinGiriniz.TabIndex = 0;
            this.LblMetinGiriniz.Text = "Metin Giriniz :";
            // 
            // LblSayiGiriniz
            // 
            this.LblSayiGiriniz.AutoSize = true;
            this.LblSayiGiriniz.Location = new System.Drawing.Point(54, 99);
            this.LblSayiGiriniz.Name = "LblSayiGiriniz";
            this.LblSayiGiriniz.Size = new System.Drawing.Size(104, 21);
            this.LblSayiGiriniz.TabIndex = 1;
            this.LblSayiGiriniz.Text = "Sayı Giriniz :";
            // 
            // TxtGirilenMetin
            // 
            this.TxtGirilenMetin.Location = new System.Drawing.Point(199, 46);
            this.TxtGirilenMetin.Name = "TxtGirilenMetin";
            this.TxtGirilenMetin.Size = new System.Drawing.Size(202, 29);
            this.TxtGirilenMetin.TabIndex = 2;
            // 
            // TxtGirilenSayi
            // 
            this.TxtGirilenSayi.Location = new System.Drawing.Point(199, 91);
            this.TxtGirilenSayi.Name = "TxtGirilenSayi";
            this.TxtGirilenSayi.Size = new System.Drawing.Size(103, 29);
            this.TxtGirilenSayi.TabIndex = 3;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(104, 145);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(100, 30);
            this.BtnYazdir.TabIndex = 4;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // LstYazdirilanMetinler
            // 
            this.LstYazdirilanMetinler.FormattingEnabled = true;
            this.LstYazdirilanMetinler.ItemHeight = 21;
            this.LstYazdirilanMetinler.Location = new System.Drawing.Point(45, 205);
            this.LstYazdirilanMetinler.Name = "LstYazdirilanMetinler";
            this.LstYazdirilanMetinler.Size = new System.Drawing.Size(356, 193);
            this.LstYazdirilanMetinler.TabIndex = 5;
            // 
            // FrmGirirlenSayiGirilenMetin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 438);
            this.Controls.Add(this.LstYazdirilanMetinler);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.TxtGirilenSayi);
            this.Controls.Add(this.TxtGirilenMetin);
            this.Controls.Add(this.LblSayiGiriniz);
            this.Controls.Add(this.LblMetinGiriniz);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmGirirlenSayiGirilenMetin";
            this.Text = "FrmGirirlenSayiGirilenMetin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblMetinGiriniz;
        private System.Windows.Forms.Label LblSayiGiriniz;
        private System.Windows.Forms.TextBox TxtGirilenMetin;
        private System.Windows.Forms.TextBox TxtGirilenSayi;
        private System.Windows.Forms.Button BtnYazdir;
        private System.Windows.Forms.ListBox LstYazdirilanMetinler;
    }
}

