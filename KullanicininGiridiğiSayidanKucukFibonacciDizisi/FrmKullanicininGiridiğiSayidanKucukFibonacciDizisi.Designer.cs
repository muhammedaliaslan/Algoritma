namespace KullanicininGiridiğiSayidanKucukFibonacciDizisi
{
    partial class FrmKullanicininGiridiğiSayidanKucukFibonacciDizisi
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
            this.txtLimit = new System.Windows.Forms.TextBox();
            this.btnYazdir = new System.Windows.Forms.Button();
            this.lstListele = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtLimit
            // 
            this.txtLimit.Location = new System.Drawing.Point(163, 38);
            this.txtLimit.Name = "txtLimit";
            this.txtLimit.Size = new System.Drawing.Size(159, 34);
            this.txtLimit.TabIndex = 0;
            // 
            // btnYazdir
            // 
            this.btnYazdir.Location = new System.Drawing.Point(60, 78);
            this.btnYazdir.Name = "btnYazdir";
            this.btnYazdir.Size = new System.Drawing.Size(364, 33);
            this.btnYazdir.TabIndex = 1;
            this.btnYazdir.Text = "Yazdır";
            this.btnYazdir.UseVisualStyleBackColor = true;
            this.btnYazdir.Click += new System.EventHandler(this.btnYazdir_Click);
            // 
            // lstListele
            // 
            this.lstListele.FormattingEnabled = true;
            this.lstListele.ItemHeight = 28;
            this.lstListele.Location = new System.Drawing.Point(60, 127);
            this.lstListele.Name = "lstListele";
            this.lstListele.Size = new System.Drawing.Size(364, 88);
            this.lstListele.TabIndex = 2;
            // 
            // FrmKullanicininGiridiğiSayidanKucukFibonacciDizisi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(511, 364);
            this.Controls.Add(this.lstListele);
            this.Controls.Add(this.btnYazdir);
            this.Controls.Add(this.txtLimit);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FrmKullanicininGiridiğiSayidanKucukFibonacciDizisi";
            this.Text = "FrmKullanicininGiridiğiSayidanKucukFibonacciDizisi";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtLimit;
        private System.Windows.Forms.Button btnYazdir;
        private System.Windows.Forms.ListBox lstListele;
    }
}

