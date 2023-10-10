namespace Fahrenayti_Santigrata_Cevirme
{
    partial class FrmFahrenaytiSantigrataCevirme
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
            this.LblFahrenheitGiriniz = new System.Windows.Forms.Label();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblFahrenheitGiriniz
            // 
            this.LblFahrenheitGiriniz.AutoSize = true;
            this.LblFahrenheitGiriniz.Location = new System.Drawing.Point(35, 28);
            this.LblFahrenheitGiriniz.Name = "LblFahrenheitGiriniz";
            this.LblFahrenheitGiriniz.Size = new System.Drawing.Size(154, 21);
            this.LblFahrenheitGiriniz.TabIndex = 0;
            this.LblFahrenheitGiriniz.Text = "Fahrenheit Giriniz :";
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(35, 77);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 1;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 29);
            this.textBox1.TabIndex = 2;
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(80, 133);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(117, 31);
            this.BtnHesapla.TabIndex = 3;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(114, 77);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 4;
            this.LblSonuc.Text = "0";
            // 
            // FrmFahrenaytiSantigrataCevirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 302);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.LblFahrenheitGiriniz);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmFahrenaytiSantigrataCevirme";
            this.Text = "FrmFahrenaytiSantigrataCevirme";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblFahrenheitGiriniz;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label LblSonuc;
    }
}

