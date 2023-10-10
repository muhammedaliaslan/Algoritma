using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanicininGirdigiSayilariTerstenSirala
{
    public partial class FrmKullanicininGirdigiSayilariTerstenSirala : Form
    {
        public FrmKullanicininGirdigiSayilariTerstenSirala()
        {
            InitializeComponent();
        }

        ArrayList elemanlar = new ArrayList();
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEklenenSayi.Text != "")
                {
                    elemanlar.Add(txtEklenenSayi.Text);
                    lstEklenenSayilar.Items.Add(txtEklenenSayi.Text);
                    txtEklenenSayi.Text = "";

                }
                else
                {
                    MessageBox.Show("Geçerli Değer Giriniz");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz");
            }

        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                elemanlar.Reverse();

                foreach (var eleman in elemanlar)
                {
                    lstSonuc.Items.Add(eleman);
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz");
            }



        }


    }
}

