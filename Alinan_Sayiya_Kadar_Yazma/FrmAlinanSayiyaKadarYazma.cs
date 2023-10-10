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

namespace Alinan_Sayiya_Kadar_Yazma
{
    public partial class FrmAlinanSayiyaKadarYazma : Form
    {
        public FrmAlinanSayiyaKadarYazma()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            int alinanSayi = 0;
            if (TxtSayiAl.Text != "" && TxtSayiAl.Text != "0")
            {
                alinanSayi = Convert.ToInt32(TxtSayiAl.Text);
            }
            else
            {
                
                MessageBox.Show("Geçerli Değer Giriniz !", "Hata");
            }




            for (int i = 1; i <= alinanSayi; i++)
            {
                LstSonuc.Items.Add(i);

            }
            TxtSayiAl.Text = "";

        }
    }
}
