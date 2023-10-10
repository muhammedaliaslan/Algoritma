namespace Su_Sicakligina_Gore_Durumu
{
    partial class FrmSuSicakliginaGoreDurumu
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
            this.LblSuDerecesi = new System.Windows.Forms.Label();
            this.TxtSuDerecesi = new System.Windows.Forms.TextBox();
            this.BtnSonuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LblSuDerecesi
            // 
            this.LblSuDerecesi.AutoSize = true;
            this.LblSuDerecesi.Location = new System.Drawing.Point(32, 47);
            this.LblSuDerecesi.Name = "LblSuDerecesi";
            this.LblSuDerecesi.Size = new System.Drawing.Size(204, 21);
            this.LblSuDerecesi.TabIndex = 0;
            this.LblSuDerecesi.Text = "Suyun Derecesini Giriniz :";
            // 
            // TxtSuDerecesi
            // 
            this.TxtSuDerecesi.Location = new System.Drawing.Point(242, 39);
            this.TxtSuDerecesi.Name = "TxtSuDerecesi";
            this.TxtSuDerecesi.Size = new System.Drawing.Size(137, 29);
            this.TxtSuDerecesi.TabIndex = 1;
            // 
            // BtnSonuc
            // 
            this.BtnSonuc.Location = new System.Drawing.Point(242, 83);
            this.BtnSonuc.Name = "BtnSonuc";
            this.BtnSonuc.Size = new System.Drawing.Size(137, 33);
            this.BtnSonuc.TabIndex = 2;
            this.BtnSonuc.Text = "Sonuç";
            this.BtnSonuc.UseVisualStyleBackColor = true;
            this.BtnSonuc.Click += new System.EventHandler(this.BtnSonuc_Click);
            // 
            // FrmSuSicakliginaGoreDurumu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 237);
            this.Controls.Add(this.BtnSonuc);
            this.Controls.Add(this.TxtSuDerecesi);
            this.Controls.Add(this.LblSuDerecesi);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmSuSicakliginaGoreDurumu";
            this.Text = "FrmSuSicakliginaGoreDurumu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblSuDerecesi;
        private System.Windows.Forms.TextBox TxtSuDerecesi;
        private System.Windows.Forms.Button BtnSonuc;
    }
}

