using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SayiAl_AdYazdir
{
    public partial class FrmSayiAlAdYazdir : Form
    {
        public FrmSayiAlAdYazdir()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                string alinanAd = "";

                int alinanSayi = 0;

                alinanAd = TxtAd.Text;

                alinanSayi = Convert.ToInt32(TxtSayi.Text);

                for (int i = 1; i <= alinanSayi; i++)
                {
                    LstSonuc.Items.Add(i + "." + alinanAd);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değerler Giriniz !");
            }
        }
    }
}
