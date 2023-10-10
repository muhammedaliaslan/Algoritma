using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bolme_Islemi
{
    public partial class FrmBolmeIslemi : Form
    {
        public FrmBolmeIslemi()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double birincisayi = 0;
                double ikincisayi = 0;
                double sonuc = 0;
                double kalan = 0;

                birincisayi = Convert.ToInt16(TxtBirinciSayi.Text);
                ikincisayi = Convert.ToInt16(TxtIkinciSayi.Text);

                sonuc = birincisayi / ikincisayi;
                kalan = birincisayi % ikincisayi;


                TxtSonuc.Text = sonuc.ToString();
                TxtKalan.Text= kalan.ToString();

            }
            catch
            {
                MessageBox.Show("Girilen değer Geçersiz", "HATA !");
            }
        }
    }
}
