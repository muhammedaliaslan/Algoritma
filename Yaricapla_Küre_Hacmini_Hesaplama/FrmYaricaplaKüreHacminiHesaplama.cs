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

namespace Yaricapla_Küre_Hacmini_Hesaplama
{
    public partial class FrmYaricaplaKüreHacminiHesaplama : Form
    {
        public FrmYaricaplaKüreHacminiHesaplama()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double yaricap = 0;
                double hacim = 0;

                yaricap = Convert.ToDouble(TxtSayiGiriniz.Text);

                //Formül: 4/3 * 3,14 * r^3

                
                hacim = (4 * Math.PI * Math.Pow(yaricap, 3)) / 3;

                LblSonuc.Text = hacim.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz");
            }
        }
    }
}
