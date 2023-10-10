namespace Yas_Hesaplama
{
    partial class FrmYasHesaplama
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.LblYasiniziGiriniz = new System.Windows.Forms.Label();
            this.BtnHesapla = new System.Windows.Forms.Button();
            this.LblYasinizBilgi = new System.Windows.Forms.Label();
            this.LblYas = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(58, 47);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(224, 29);
            this.dateTimePicker1.TabIndex = 0;
            // 
            // LblYasiniziGiriniz
            // 
            this.LblYasiniziGiriniz.AutoSize = true;
            this.LblYasiniziGiriniz.Location = new System.Drawing.Point(105, 9);
            this.LblYasiniziGiriniz.Name = "LblYasiniziGiriniz";
            this.LblYasiniziGiriniz.Size = new System.Drawing.Size(130, 21);
            this.LblYasiniziGiriniz.TabIndex = 1;
            this.LblYasiniziGiriniz.Text = "Yaşınızı Giriniz :";
            // 
            // BtnHesapla
            // 
            this.BtnHesapla.Location = new System.Drawing.Point(58, 93);
            this.BtnHesapla.Name = "BtnHesapla";
            this.BtnHesapla.Size = new System.Drawing.Size(224, 31);
            this.BtnHesapla.TabIndex = 2;
            this.BtnHesapla.Text = "Hesapla";
            this.BtnHesapla.UseVisualStyleBackColor = true;
            this.BtnHesapla.Click += new System.EventHandler(this.BtnHesapla_Click);
            // 
            // LblYasinizBilgi
            // 
            this.LblYasinizBilgi.AutoSize = true;
            this.LblYasinizBilgi.Location = new System.Drawing.Point(54, 158);
            this.LblYasinizBilgi.Name = "LblYasinizBilgi";
            this.LblYasinizBilgi.Size = new System.Drawing.Size(71, 21);
            this.LblYasinizBilgi.TabIndex = 3;
            this.LblYasinizBilgi.Text = "Yaşınız :";
            // 
            // LblYas
            // 
            this.LblYas.AutoSize = true;
            this.LblYas.Location = new System.Drawing.Point(140, 158);
            this.LblYas.Name = "LblYas";
            this.LblYas.Size = new System.Drawing.Size(19, 21);
            this.LblYas.TabIndex = 4;
            this.LblYas.Text = "0";
            // 
            // FrmYasHesaplama
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 410);
            this.Controls.Add(this.LblYas);
            this.Controls.Add(this.LblYasinizBilgi);
            this.Controls.Add(this.BtnHesapla);
            this.Controls.Add(this.LblYasiniziGiriniz);
            this.Controls.Add(this.dateTimePicker1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "FrmYasHesaplama";
            this.Text = "FrmYasHesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label LblYasiniziGiriniz;
        private System.Windows.Forms.Button BtnHesapla;
        private System.Windows.Forms.Label LblYasinizBilgi;
        private System.Windows.Forms.Label LblYas;
    }
}

