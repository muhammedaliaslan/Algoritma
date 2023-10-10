using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace While_Ile_Ad_Yazdirma
{
    public partial class FrmWhileIleAdYazdirma : Form
    {
        public FrmWhileIleAdYazdirma()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                string kullaniciAd = "";

                kullaniciAd = TxtAd.Text;

                int sayi = 0;

                sayi = Convert.ToInt32(TxtSayi.Text);

                int i = 1;
                while (i <= sayi)
                {
                    LstSonuc.Items.Add(i + " . " + kullaniciAd);
                    i++;
                }
            }
            catch
            {
                MessageBox.Show("Geçerli Değer Giriniz ! ");
            }
        }
    }
}
