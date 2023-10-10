namespace Bin_Sayi_Al_Yazdir
{
    partial class FrmBesSayiAlTopla
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
            this.TxtAlinanSayi = new System.Windows.Forms.TextBox();
            this.LblSayıEkle = new System.Windows.Forms.Label();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LstEklenenSayilar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // TxtAlinanSayi
            // 
            this.TxtAlinanSayi.Location = new System.Drawing.Point(265, 60);
            this.TxtAlinanSayi.Name = "TxtAlinanSayi";
            this.TxtAlinanSayi.Size = new System.Drawing.Size(109, 34);
            this.TxtAlinanSayi.TabIndex = 0;
            // 
            // LblSayıEkle
            // 
            this.LblSayıEkle.AutoSize = true;
            this.LblSayıEkle.Location = new System.Drawing.Point(152, 63);
            this.LblSayıEkle.Name = "LblSayıEkle";
            this.LblSayıEkle.Size = new System.Drawing.Size(107, 28);
            this.LblSayıEkle.TabIndex = 1;
            this.LblSayıEkle.Text = "Sayı Ekle :";
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(157, 116);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(225, 37);
            this.BtnEkle.TabIndex = 2;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LstEklenenSayilar
            // 
            this.LstEklenenSayilar.FormattingEnabled = true;
            this.LstEklenenSayilar.ItemHeight = 28;
            this.LstEklenenSayilar.Location = new System.Drawing.Point(157, 165);
            this.LstEklenenSayilar.Name = "LstEklenenSayilar";
            this.LstEklenenSayilar.Size = new System.Drawing.Size(225, 172);
            this.LstEklenenSayilar.TabIndex = 3;
            // 
            // FrmBesSayiAlTopla
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 443);
            this.Controls.Add(this.LstEklenenSayilar);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.LblSayıEkle);
            this.Controls.Add(this.TxtAlinanSayi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmBesSayiAlTopla";
            this.Text = "FrmBesSayiAlTopla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtAlinanSayi;
        private System.Windows.Forms.Label LblSayıEkle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ListBox LstEklenenSayilar;
    }
}

