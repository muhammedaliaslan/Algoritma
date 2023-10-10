using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Faktoriyel_Hesaplama
{
    public partial class FrmFaktoriyelHesaplama : Form
    {
        public FrmFaktoriyelHesaplama()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = 0;

                sayi = Convert.ToInt32(TxtSayi.Text);

                int sonuc = 1;

                for (int i = 1; i <= sayi; i++)
                {
                    sonuc = sonuc * (i);
                }
                LblSonuc.Text = sayi + "! =" + sonuc.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz!");
            }
           
        }
    }
}
