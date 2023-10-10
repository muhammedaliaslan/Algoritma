namespace Tam_Sayi_Kontrolu
{
    partial class FrmTamSayiKontrolu
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
            this.BtnSonuc = new System.Windows.Forms.Button();
            this.TxtSayiGiriniz = new System.Windows.Forms.TextBox();
            this.LblSayi = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtnSonuc
            // 
            this.BtnSonuc.Location = new System.Drawing.Point(180, 67);
            this.BtnSonuc.Name = "BtnSonuc";
            this.BtnSonuc.Size = new System.Drawing.Size(137, 33);
            this.BtnSonuc.TabIndex = 5;
            this.BtnSonuc.Text = "Sonuç";
            this.BtnSonuc.UseVisualStyleBackColor = true;
            this.BtnSonuc.Click += new System.EventHandler(this.BtnSonuc_Click);
            // 
            // TxtSayiGiriniz
            // 
            this.TxtSayiGiriniz.Location = new System.Drawing.Point(180, 23);
            this.TxtSayiGiriniz.Name = "TxtSayiGiriniz";
            this.TxtSayiGiriniz.Size = new System.Drawing.Size(137, 29);
            this.TxtSayiGiriniz.TabIndex = 4;
            // 
            // LblSayi
            // 
            this.LblSayi.AutoSize = true;
            this.LblSayi.Location = new System.Drawing.Point(58, 31);
            this.LblSayi.Name = "LblSayi";
            this.LblSayi.Size = new System.Drawing.Size(104, 21);
            this.LblSayi.TabIndex = 3;
            this.LblSayi.Text = "Sayı Giriniz :";
            // 
            // FrmTamSayiKontrolu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 160);
            this.Controls.Add(this.BtnSonuc);
            this.Controls.Add(this.TxtSayiGiriniz);
            this.Controls.Add(this.LblSayi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmTamSayiKontrolu";
            this.Text = "FrmTamSayiKontrolu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnSonuc;
        private System.Windows.Forms.TextBox TxtSayiGiriniz;
        private System.Windows.Forms.Label LblSayi;
    }
}

