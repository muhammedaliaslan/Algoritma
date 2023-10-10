using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GirirlenSayi_GirilenMetin
{
    public partial class FrmGirirlenSayiGirilenMetin : Form
    {
        public FrmGirirlenSayiGirilenMetin()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                string metin = "";

                metin = TxtGirilenMetin.Text;

                int sayi = 0;

                sayi = Convert.ToInt32(TxtGirilenSayi.Text);

                for (int i = 1; i<=sayi; i++) 
                {
                    LstYazdirilanMetinler.Items.Add(i+"."+metin);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz !");
            }

        }
    }
}
