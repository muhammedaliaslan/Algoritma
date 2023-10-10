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

namespace Carpma_Kullanmadan_Iki_Sayiyi_Carp
{
    public partial class FrmCarpmaKullanmadanIkiSayiyiCarp : Form
    {
        public FrmCarpmaKullanmadanIkiSayiyiCarp()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                int ilkSayi = 0;
                int ikinciSayi = 0;

                int carpim = 0;


                ilkSayi = Convert.ToInt32(TxtSayiBir.Text);
                ikinciSayi = Convert.ToInt32(TxtSayiIki.Text);



                for (int i = 0; i < ikinciSayi; i++)
                {
                    carpim += ilkSayi;
                }

                LblSonuc.Text = carpim.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz");
            }
        }
    }
}
