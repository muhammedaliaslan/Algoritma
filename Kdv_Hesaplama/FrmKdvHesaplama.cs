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

namespace Kdv_Hesaplama
{
    public partial class FrmKdvHesaplama : Form
    {
        public FrmKdvHesaplama()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double fiyat = 0;
                fiyat = Convert.ToDouble(TxtFiyat.Text);

                fiyat = fiyat + (fiyat * 0.18);

                LblSonuc.Text = fiyat.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz.");

            }

        }
    }
}
