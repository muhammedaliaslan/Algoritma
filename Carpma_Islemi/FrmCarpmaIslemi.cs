using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carpma_Islemi
{
    public partial class FrmCarpmaIslemi : Form
    {
        public FrmCarpmaIslemi()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double sayiBir = 0;
                double sayiIki = 0;

                double sonuc = 0;

                sayiBir = Convert.ToDouble(TxtSayiBir.Text);
                sayiIki = Convert.ToDouble(TxtSayiIki.Text);

                sonuc = sayiBir * sayiIki;

                TxtSonuc.Text = sonuc.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz");
            }
            

        }
    }
}
