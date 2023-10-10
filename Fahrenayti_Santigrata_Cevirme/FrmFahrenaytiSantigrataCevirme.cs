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

namespace Fahrenayti_Santigrata_Cevirme
{
    public partial class FrmFahrenaytiSantigrataCevirme : Form
    {
        public FrmFahrenaytiSantigrataCevirme()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                double fahrenheit = 0;

                if (textBox1.Text != "")
                {
                    fahrenheit = Convert.ToDouble(textBox1.Text);
                    LblSonuc.Text = Convert.ToString((fahrenheit - 32) / 1.8 + " Santigrat");
                }
                else
                {
                    MessageBox.Show("Lütfen Değer Giriniz. ");
                }

                
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz.");
            }
        }
    }
}
