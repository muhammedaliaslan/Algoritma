namespace Puan_Hesaplama
{
    partial class FrmPuanHesaplama
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
            this.LblSinavBir = new System.Windows.Forms.Label();
            this.LblSinavIki = new System.Windows.Forms.Label();
            this.LblSinavUc = new System.Windows.Forms.Label();
            this.TxtSinavBir = new System.Windows.Forms.TextBox();
            this.TxtSinavIki = new System.Windows.Forms.TextBox();
            this.TxtSinavUc = new System.Windows.Forms.TextBox();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSinavBir
            // 
            this.LblSinavBir.AutoSize = true;
            this.LblSinavBir.Location = new System.Drawing.Point(66, 44);
            this.LblSinavBir.Name = "LblSinavBir";
            this.LblSinavBir.Size = new System.Drawing.Size(73, 21);
            this.LblSinavBir.TabIndex = 0;
            this.LblSinavBir.Text = "1.Sınav :";
            // 
            // LblSinavIki
            // 
            this.LblSinavIki.AutoSize = true;
            this.LblSinavIki.Location = new System.Drawing.Point(66, 83);
            this.LblSinavIki.Name = "LblSinavIki";
            this.LblSinavIki.Size = new System.Drawing.Size(73, 21);
            this.LblSinavIki.TabIndex = 1;
            this.LblSinavIki.Text = "2.Sınav :";
            // 
            // LblSinavUc
            // 
            this.LblSinavUc.AutoSize = true;
            this.LblSinavUc.Location = new System.Drawing.Point(66, 122);
            this.LblSinavUc.Name = "LblSinavUc";
            this.LblSinavUc.Size = new System.Drawing.Size(73, 21);
            this.LblSinavUc.TabIndex = 2;
            this.LblSinavUc.Text = "3.Sınav :";
            // 
            // TxtSinavBir
            // 
            this.TxtSinavBir.Location = new System.Drawing.Point(139, 40);
            this.TxtSinavBir.Name = "TxtSinavBir";
            this.TxtSinavBir.Size = new System.Drawing.Size(100, 29);
            this.TxtSinavBir.TabIndex = 3;
            // 
            // TxtSinavIki
            // 
            this.TxtSinavIki.Location = new System.Drawing.Point(139, 79);
            this.TxtSinavIki.Name = "TxtSinavIki";
            this.TxtSinavIki.Size = new System.Drawing.Size(100, 29);
            this.TxtSinavIki.TabIndex = 4;
            // 
            // TxtSinavUc
            // 
            this.TxtSinavUc.Location = new System.Drawing.Point(139, 118);
            this.TxtSinavUc.Name = "TxtSinavUc";
            this.TxtSinavUc.Size = new System.Drawing.Size(100, 29);
            this.TxtSinavUc.TabIndex = 5;
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(318, 48);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 6;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(381, 48);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 7;
            this.LblSonuc.Text = "0";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(139, 169);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(100, 30);
            this.BtnHesapla.TabIndex = 8;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // FrmPuanHesaplama
            // 
            this.AcceptButton = this.BtnHesapla;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 445);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.TxtSinavUc);
            this.Controls.Add(this.TxtSinavIki);
            this.Controls.Add(this.TxtSinavBir);
            this.Controls.Add(this.LblSinavUc);
            this.Controls.Add(this.LblSinavIki);
            this.Controls.Add(this.LblSinavBir);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmPuanHesaplama";
            this.Text = "FrmPuanHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSinavBir;
        private System.Windows.Forms.Label LblSinavIki;
        private System.Windows.Forms.Label LblSinavUc;
        private System.Windows.Forms.TextBox TxtSinavBir;
        private System.Windows.Forms.TextBox TxtSinavIki;
        private System.Windows.Forms.TextBox TxtSinavUc;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.Label LblSonuc;
        private System.Windows.Forms.Button BtnHesapla;
    }
}

