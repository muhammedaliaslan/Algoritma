namespace Ucgen_Hipotenus_Hesaplama
{
    partial class FrmUcgenHipotenusHesaplama
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
            this.LblBirinciKenar = new System.Windows.Forms.Label();
            this.LblIkinciKenar = new System.Windows.Forms.Label();
            this.TxtBirinciKenar = new System.Windows.Forms.TextBox();
            this.TxtIkinciKenar = new System.Windows.Forms.TextBox();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.LblSonucBilgi = new System.Windows.Forms.Label();
            this.LblSonuc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LblBirinciKenar
            // 
            this.LblBirinciKenar.AutoSize = true;
            this.LblBirinciKenar.Location = new System.Drawing.Point(29, 53);
            this.LblBirinciKenar.Name = "LblBirinciKenar";
            this.LblBirinciKenar.Size = new System.Drawing.Size(115, 21);
            this.LblBirinciKenar.TabIndex = 0;
            this.LblBirinciKenar.Text = "Birinci Kenar :";
            // 
            // LblIkinciKenar
            // 
            this.LblIkinciKenar.AutoSize = true;
            this.LblIkinciKenar.Location = new System.Drawing.Point(36, 91);
            this.LblIkinciKenar.Name = "LblIkinciKenar";
            this.LblIkinciKenar.Size = new System.Drawing.Size(108, 21);
            this.LblIkinciKenar.TabIndex = 1;
            this.LblIkinciKenar.Text = "İkinci Kenar :";
            // 
            // TxtBirinciKenar
            // 
            this.TxtBirinciKenar.Location = new System.Drawing.Point(157, 49);
            this.TxtBirinciKenar.Name = "TxtBirinciKenar";
            this.TxtBirinciKenar.Size = new System.Drawing.Size(100, 29);
            this.TxtBirinciKenar.TabIndex = 2;
            // 
            // TxtIkinciKenar
            // 
            this.TxtIkinciKenar.Location = new System.Drawing.Point(157, 87);
            this.TxtIkinciKenar.Name = "TxtIkinciKenar";
            this.TxtIkinciKenar.Size = new System.Drawing.Size(100, 29);
            this.TxtIkinciKenar.TabIndex = 3;
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(157, 137);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(100, 32);
            this.BtnHesapla.TabIndex = 4;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // LblSonucBilgi
            // 
            this.LblSonucBilgi.AutoSize = true;
            this.LblSonucBilgi.Location = new System.Drawing.Point(281, 53);
            this.LblSonucBilgi.Name = "LblSonucBilgi";
            this.LblSonucBilgi.Size = new System.Drawing.Size(65, 21);
            this.LblSonucBilgi.TabIndex = 5;
            this.LblSonucBilgi.Text = "Sonuç :";
            // 
            // LblSonuc
            // 
            this.LblSonuc.AutoSize = true;
            this.LblSonuc.Location = new System.Drawing.Point(363, 53);
            this.LblSonuc.Name = "LblSonuc";
            this.LblSonuc.Size = new System.Drawing.Size(19, 21);
            this.LblSonuc.TabIndex = 6;
            this.LblSonuc.Text = "0";
            // 
            // FrmUcgenHipotenusHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(517, 321);
            this.Controls.Add(this.LblSonuc);
            this.Controls.Add(this.LblSonucBilgi);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.TxtIkinciKenar);
            this.Controls.Add(this.TxtBirinciKenar);
            this.Controls.Add(this.LblIkinciKenar);
            this.Controls.Add(this.LblBirinciKenar);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmUcgenHipotenusHesaplama";
            this.Text = "FrmUcgenHipotenusHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblBirinciKenar;
        private System.Windows.Forms.Label LblIkinciKenar;
        private System.Windows.Forms.TextBox TxtBirinciKenar;
        private System.Windows.Forms.TextBox TxtIkinciKenar;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label LblSonucBilgi;
        private System.Windows.Forms.Label LblSonuc;
    }
}

