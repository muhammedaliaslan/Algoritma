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

namespace IkiSayiAl_TekYazdir
{
    public partial class FrmIkiSayiAlTekYazdir : Form
    {
        public FrmIkiSayiAlTekYazdir()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {



                int ilkSayi = 0;
                int ikinciSayi = 0;

                ilkSayi = Convert.ToInt32(TxtSayiBir.Text);
                ikinciSayi = Convert.ToInt32(TxtSayiIki.Text);

                if (ilkSayi < ikinciSayi)
                {
                    for (int i = ilkSayi; i <= ikinciSayi; i++)
                    {
                        if (i % 2 == 1)
                        {
                            LstYazdirilanSayilar.Items.Add(i);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("İlk Sayı Küçük Olmalıdır.");
                }


            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz !");
            }
        }
    }
}
