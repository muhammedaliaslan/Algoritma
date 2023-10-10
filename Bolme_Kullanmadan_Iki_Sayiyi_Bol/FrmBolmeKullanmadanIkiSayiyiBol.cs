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

namespace Bolme_Kullanmadan_Iki_Sayiyi_Bol
{
    public partial class FrmBolmeKullanmadanIkiSayiyiBol : Form
    {
        public FrmBolmeKullanmadanIkiSayiyiBol()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {


                double ilkSayi = 0;
                double ikinciSayi = 0;

                double bolum = 0;
                double kalan = 0;


                ilkSayi = Convert.ToDouble(TxtSayiBir.Text);
                ikinciSayi = Convert.ToDouble(TxtSayiIki.Text);

                
                while (ilkSayi >= ikinciSayi)
                {
                    ilkSayi -= ikinciSayi;
                    bolum++;
                }

                kalan = ilkSayi % ikinciSayi;

                LblSonuc.Text = bolum.ToString();
                LblKalan.Text = kalan.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz.");
            }
        }
    }
}
