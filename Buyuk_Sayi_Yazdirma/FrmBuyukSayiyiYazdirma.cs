using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Buyuk_Sayi_Yazdirma
{
    public partial class FrmBuyukSayiyiYazdirma : Form
    {
        public FrmBuyukSayiyiYazdirma()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                int birinciSayi = 0;
                
                int ikinciSayi = 0;

                birinciSayi = Convert.ToInt32(TxtBirinciSayi.Text);

                ikinciSayi = Convert.ToInt32(TxtIkinciSayi.Text);


                if (birinciSayi > ikinciSayi)
                {
                    LblSonuc.Text = birinciSayi.ToString();
                }
                else
                {
                    LblSonuc.Text = ikinciSayi.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz. ", "HATA!");
            }
        }
    }
}
