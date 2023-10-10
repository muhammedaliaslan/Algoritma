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

namespace Algoritma
{
    public partial class FrmToplamiYazdirma : Form
    {
        public FrmToplamiYazdirma()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {


                int birinciSayi = 0;
                int ikinciSayi = 0;
                int sonuc = 0;

                birinciSayi = Convert.ToInt32(TxtSayiBir.Text);
                ikinciSayi = Convert.ToInt32(TxtSayiIki.Text);

                sonuc = birinciSayi + ikinciSayi;

                TxtSonuc.Text = sonuc.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz");
            }
        }
    }
}
