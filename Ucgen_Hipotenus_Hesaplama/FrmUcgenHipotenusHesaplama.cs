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

namespace Ucgen_Hipotenus_Hesaplama
{
    public partial class FrmUcgenHipotenusHesaplama : Form
    {
        public FrmUcgenHipotenusHesaplama()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int birinciKenar = 0;
                int ikinciKenar = 0;

                birinciKenar = Convert.ToInt32(TxtBirinciKenar.Text);
                ikinciKenar = Convert.ToInt32(TxtIkinciKenar.Text);

                int ikiKenarınKaresi = 0;
                ikiKenarınKaresi = (birinciKenar * birinciKenar) + (ikinciKenar * ikinciKenar);

                double sonuc = 0;
                sonuc = Math.Sqrt(ikiKenarınKaresi);
                LblSonuc.Text = sonuc.ToString();


            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Girin", "HATA !");
            }

        }
    }
}
