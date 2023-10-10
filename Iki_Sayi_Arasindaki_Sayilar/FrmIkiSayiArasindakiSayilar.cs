using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Iki_Sayi_Arasindaki_Sayilar
{
    public partial class FrmIkiSayiArasindakiSayilar : Form
    {
        public FrmIkiSayiArasindakiSayilar()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                int sayiBir = 0;
                int sayiIki = 0;

                sayiBir = Convert.ToInt32(TxtSayiBir.Text);
                sayiIki = Convert.ToInt32(TxtSayiIki.Text);

                if (sayiBir < sayiIki)
                {
                    for (int i = sayiBir; i < sayiIki; i++)
                    {
                        LstYazdirilanSayilar.Items.Add(i);
                    }
                }
                else
                {
                    MessageBox.Show("İlk Değer Küçük  Olmalıdır!");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz !");
            }
            
        }
    }
}
