namespace OnDefa_AdYazdırma
{
    partial class FrmOnDefaAdYazdırma
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
            this.LstOnDefaAdYazdirma = new System.Windows.Forms.ListBox();
            this.BtnYazdir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LstOnDefaAdYazdirma
            // 
            this.LstOnDefaAdYazdirma.FormattingEnabled = true;
            this.LstOnDefaAdYazdirma.ItemHeight = 21;
            this.LstOnDefaAdYazdirma.Location = new System.Drawing.Point(66, 36);
            this.LstOnDefaAdYazdirma.Name = "LstOnDefaAdYazdirma";
            this.LstOnDefaAdYazdirma.Size = new System.Drawing.Size(260, 235);
            this.LstOnDefaAdYazdirma.TabIndex = 0;
            // 
            // BtnYazdir
            // 
            this.BtnYazdir.Location = new System.Drawing.Point(66, 287);
            this.BtnYazdir.Name = "BtnYazdir";
            this.BtnYazdir.Size = new System.Drawing.Size(260, 31);
            this.BtnYazdir.TabIndex = 1;
            this.BtnYazdir.Text = "Yazdır";
            this.BtnYazdir.UseVisualStyleBackColor = true;
            this.BtnYazdir.Click += new System.EventHandler(this.BtnYazdir_Click);
            // 
            // FrmOnDefaAdYazdırma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 360);
            this.Controls.Add(this.BtnYazdir);
            this.Controls.Add(this.LstOnDefaAdYazdirma);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmOnDefaAdYazdırma";
            this.Text = "FrmOnDefaAdYazdırma";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox LstOnDefaAdYazdirma;
        private System.Windows.Forms.Button BtnYazdir;
    }
}

