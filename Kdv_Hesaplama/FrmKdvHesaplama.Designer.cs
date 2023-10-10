namespace Kdv_Hesaplama
{
    partial class FrmKdvHesaplama
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
            this.LblFiyat = new System.Windows.Forms.Label();
            this.TxtFiyat = new System.Windows.Forms.TextBox();
            this.LblKdv = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.LblYuzdeOnSekiz = new System.Windows.Forms.Label();
            this.LblToplamTutar = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFiyat
            // 
            this.LblFiyat.AutoSize = true;
            this.LblFiyat.Location = new System.Drawing.Point(48, 50);
            this.LblFiyat.Name = "LblFiyat";
            this.LblFiyat.Size = new System.Drawing.Size(55, 21);
            this.LblFiyat.TabIndex = 0;
            this.LblFiyat.Text = "Fiyat :";
            // 
            // TxtFiyat
            // 
            this.TxtFiyat.Location = new System.Drawing.Point(124, 46);
            this.TxtFiyat.Name = "TxtFiyat";
            this.TxtFiyat.Size = new System.Drawing.Size(100, 29);
            this.TxtFiyat.TabIndex = 1;
            // 
            // LblKdv
            // 
            this.LblKdv.AutoSize = true;
            this.LblKdv.Location = new System.Drawing.Point(48, 85);
            this.LblKdv.Name = "LblKdv";
            this.LblKdv.Size = new System.Drawing.Size(47, 21);
            this.LblKdv.TabIndex = 2;
            this.LblKdv.Text = "Kdv :";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(124, 122);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(100, 29);
            this.BtnHesapla.TabIndex = 3;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // LblYuzdeOnSekiz
            // 
            this.LblYuzdeOnSekiz.AutoSize = true;
            this.LblYuzdeOnSekiz.Location = new System.Drawing.Point(124, 85);
            this.LblYuzdeOnSekiz.Name = "LblYuzdeOnSekiz";
            this.LblYuzdeOnSekiz.Size = new System.Drawing.Size(42, 21);
            this.LblYuzdeOnSekiz.TabIndex = 4;
            this.LblYuzdeOnSekiz.Text = "%18";
            // 
            // LblToplamTutar
            // 
            this.LblToplamTutar.AutoSize = true;
            this.LblToplamTutar.Location = new System.Drawing.Point(48, 175);
            this.LblToplamTutar.Name = "LblToplamTutar";
            this.LblToplamTutar.Size = new System.Drawing.Size(118, 21);
            this.LblToplamTutar.TabIndex = 5;
            this.LblToplamTutar.Text = "Toplam Tutar :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(172, 175);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 6;
            this.LblSonuc.Text = "0";
            // 
            // FrmKdvHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 279);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.LblToplamTutar);
            this.Controls.Add(this.LblYuzdeOnSekiz);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.LblKdv);
            this.Controls.Add(this.TxtFiyat);
            this.Controls.Add(this.LblFiyat);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmKdvHesaplama";
            this.Text = "FrmKdvHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFiyat;
        private System.Windows.Forms.TextBox TxtFiyat;
        private System.Windows.Forms.Label LblKdv;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label LblYuzdeOnSekiz;
        private System.Windows.Forms.Label LblToplamTutar;
        private System.Windows.Forms.Label LblSonuc;
    }
}

