using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanicidanIkiSayiAlUssuYaz
{
    public partial class FrmKullanicidanIkiSayiAlUssuYaz : Form
    {
        public FrmKullanicidanIkiSayiAlUssuYaz()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            double sayiBir = 0;
            double sayiIki = 0;

            double usSonuc = 0;

            if (double.TryParse(txtSayiBir.Text, out sayiBir) && double.TryParse(txtSayiIki.Text, out sayiIki))
            {
                
                usSonuc = Math.Pow(sayiBir, sayiIki);

                txtSonuc.Text=Convert.ToString(usSonuc);


            }
            else
            {
                MessageBox.Show("Geçerli sayılar girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
