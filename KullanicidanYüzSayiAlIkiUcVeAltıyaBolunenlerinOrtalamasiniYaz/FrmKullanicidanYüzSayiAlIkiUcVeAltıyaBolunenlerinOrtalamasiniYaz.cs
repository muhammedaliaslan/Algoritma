using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanicidanYüzSayiAlIkiUcVeAltıyaBolunenlerinOrtalamasiniYaz
{
    public partial class FrmKullanicidanYüzSayiAlIkiUcVeAltıyaBolunenlerinOrtalamasiniYaz : Form
    {
        public FrmKullanicidanYüzSayiAlIkiUcVeAltıyaBolunenlerinOrtalamasiniYaz()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac < 100)
                {
                    int alinanSayi = 0;
                    alinanSayi = Convert.ToInt32(txtEklenenSayilar.Text);


                    //if (alinanSayi % 2 == 0 || alinanSayi % 3 == 0 || alinanSayi % 6 == 0)
                    //{

                    //}
                    //else
                    //{
                    //    MessageBox.Show("Geçerli Değer Girin");
                    //}

                    if (alinanSayi % 2 == 0)
                    {
                        lstIkiyeBölünen.Items.Add(alinanSayi);
                    }
                    if (alinanSayi % 3 == 0)
                    {
                        lstUceBolunen.Items.Add(alinanSayi);
                    }
                    if (alinanSayi % 6 == 0)
                    {
                        lstAltiyaBolunen.Items.Add(alinanSayi);
                    }

                    txtEklenenSayilar.Text = "";
                    sayac++;
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz.");
                txtEklenenSayilar.Text = "";

            }

        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {


            if (sayac == 100)
            {

                double ikiyeBolunen = 0;

                double uceBolunen = 0;

                double altiyaBolunen = 0;



                for (int i = 0; i < lstIkiyeBölünen.Items.Count; i++)
                {
                    ikiyeBolunen += Convert.ToDouble(lstIkiyeBölünen.Items[i].ToString()) / lstIkiyeBölünen.Items.Count;

                }
                lblIkiyeBölünenlerinOrtalaması.Text = ikiyeBolunen.ToString();


                for (int i = 0; i < lstUceBolunen.Items.Count; i++)
                {
                    uceBolunen += Convert.ToDouble(lstUceBolunen.Items[i].ToString()) / lstUceBolunen.Items.Count;

                }
                lblUceBolunenlerinOrtalaması.Text = uceBolunen.ToString();

                for (int i = 0; i < lstAltiyaBolunen.Items.Count; i++)
                {
                    altiyaBolunen += Convert.ToDouble(lstAltiyaBolunen.Items[i].ToString()) / lstAltiyaBolunen.Items.Count;

                }
                lblAltıyaBolunenlerinOrtalaması.Text = altiyaBolunen.ToString();
            }
        }
    }
}