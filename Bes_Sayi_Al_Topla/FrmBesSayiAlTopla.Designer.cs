namespace Bes_Sayi_Al_Topla
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
            this.TxtEkle = new System.Windows.Forms.TextBox();
            this.BtnEkle = new System.Windows.Forms.Button();
            this.LstEklenenSayilar = new System.Windows.Forms.ListBox();
            this.BtnTopla = new System.Windows.Forms.Button();
            this.LblSonucGoster = new System.Windows.Forms.Label();
            this.LblSonucYaz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TxtEkle
            // 
            this.TxtEkle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TxtEkle.Location = new System.Drawing.Point(85, 54);
            this.TxtEkle.Name = "TxtEkle";
            this.TxtEkle.Size = new System.Drawing.Size(182, 29);
            this.TxtEkle.TabIndex = 0;
            // 
            // BtnEkle
            // 
            this.BtnEkle.Location = new System.Drawing.Point(85, 89);
            this.BtnEkle.Name = "BtnEkle";
            this.BtnEkle.Size = new System.Drawing.Size(182, 30);
            this.BtnEkle.TabIndex = 1;
            this.BtnEkle.Text = "Ekle";
            this.BtnEkle.UseVisualStyleBackColor = true;
            this.BtnEkle.Click += new System.EventHandler(this.BtnEkle_Click);
            // 
            // LstEklenenSayilar
            // 
            this.LstEklenenSayilar.FormattingEnabled = true;
            this.LstEklenenSayilar.ItemHeight = 21;
            this.LstEklenenSayilar.Location = new System.Drawing.Point(85, 125);
            this.LstEklenenSayilar.Name = "LstEklenenSayilar";
            this.LstEklenenSayilar.Size = new System.Drawing.Size(182, 172);
            this.LstEklenenSayilar.TabIndex = 2;
            // 
            // BtnTopla
            // 
            this.BtnTopla.Location = new System.Drawing.Point(85, 303);
            this.BtnTopla.Name = "BtnTopla";
            this.BtnTopla.Size = new System.Drawing.Size(182, 30);
            this.BtnTopla.TabIndex = 3;
            this.BtnTopla.Text = "Topla";
            this.BtnTopla.UseVisualStyleBackColor = true;
            this.BtnTopla.Click += new System.EventHandler(this.BtnTopla_Click);
            // 
            // LblSonucGoster
            // 
            this.LblSonucGoster.AutoSize = true;
            this.LblSonucGoster.Location = new System.Drawing.Point(81, 360);
            this.LblSonucGoster.Name = "LblSonucGoster";
            this.LblSonucGoster.Size = new System.Drawing.Size(65, 21);
            this.LblSonucGoster.TabIndex = 4;
            this.LblSonucGoster.Text = "Sonuç :";
            // 
            // LblSonucYaz
            // 
            this.LblSonucYaz.AutoSize = true;
            this.LblSonucYaz.Location = new System.Drawing.Point(164, 360);
            this.LblSonucYaz.Name = "LblSonucYaz";
            this.LblSonucYaz.Size = new System.Drawing.Size(28, 21);
            this.LblSonucYaz.TabIndex = 5;
            this.LblSonucYaz.Text = "00";
            // 
            // FrmBesSayiAlTopla
            // 
            this.AcceptButton = this.BtnEkle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 516);
            this.Controls.Add(this.LblSonucYaz);
            this.Controls.Add(this.LblSonucGoster);
            this.Controls.Add(this.BtnTopla);
            this.Controls.Add(this.LstEklenenSayilar);
            this.Controls.Add(this.BtnEkle);
            this.Controls.Add(this.TxtEkle);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "FrmBesSayiAlTopla";
            this.Text = "FrmBesSayiAlTopla";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtEkle;
        private System.Windows.Forms.Button BtnEkle;
        private System.Windows.Forms.ListBox LstEklenenSayilar;
        private System.Windows.Forms.Button BtnTopla;
        private System.Windows.Forms.Label LblSonucGoster;
        private System.Windows.Forms.Label LblSonucYaz;
    }
}

