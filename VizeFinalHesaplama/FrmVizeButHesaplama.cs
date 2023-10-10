using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VizeFinalHesaplama
{
    public partial class FrmVizeButHesaplama : Form
    {
        public FrmVizeButHesaplama()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {

                int vizeNotu = 0;
                int butNotu = 0;



                double ortalama = 0;

                vizeNotu = Convert.ToInt32(txtVizeNotu.Text);

                butNotu = Convert.ToInt32(txtButNot.Text);

                if (vizeNotu >= 0 && vizeNotu <= 100 && butNotu >= 0 && butNotu <= 100)
                {


                    ortalama = (vizeNotu * 0.40) + (butNotu * 0.60);

                    lblSonuc.Text = Convert.ToString(ortalama);

                    if (ortalama > 50)
                    {
                        lblDurum.Text = "Geçtiniz";



                    }
                    else
                    {
                        lblDurum.Text = ("Kaldınız");



                    }
                }
                else
                {
                    MessageBox.Show("0-100 Arasında Değer Girin");
                }


            }
            catch
            {
                MessageBox.Show("0-100 Arasında Değer Girin");

            }

        }
    }
}
