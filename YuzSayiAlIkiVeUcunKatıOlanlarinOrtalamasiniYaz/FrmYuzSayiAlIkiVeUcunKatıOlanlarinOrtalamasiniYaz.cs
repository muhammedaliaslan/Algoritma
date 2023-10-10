using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace YuzSayiAlIkiVeUcunKatıOlanlarinOrtalamasiniYaz
{
    public partial class FrmYuzSayiAlIkiVeUcunKatıOlanlarinOrtalamasiniYaz : Form
    {
        public FrmYuzSayiAlIkiVeUcunKatıOlanlarinOrtalamasiniYaz()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {

            //int alinanSayi = 0;
            //alinanSayi = Convert.ToInt32(txtEklenenSayilar.Text);

            //if (alinanSayi % 2 == 0 && alinanSayi % 3 == 0)

            try
            {
                int katlar = 0;
                katlar = Convert.ToInt32(txtEklenenSayilar.Text);

                if (sayac < 100)
                {
                    if (txtEklenenSayilar.Text != "")
                    {


                        lstEklenenSayilar.Items.Add(txtEklenenSayilar.Text);
                        if (katlar % 2 == 0 && katlar % 3 == 0)
                        {
                            lstKatlar.Items.Add(katlar);
                        }
                        sayac++;

                        txtEklenenSayilar.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Değer Giriniz", "HATA !");
                    }
                    txtEklenenSayilar.Text = "";


                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz.");
            }
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            if (sayac == 100)
            {
                

                
                double ortalama = 0;




                for (int i = 0; i < lstKatlar.Items.Count; i++)
                {
                    ortalama += Convert.ToDouble(lstKatlar.Items[i].ToString()) / lstKatlar.Items.Count;
                }
                lblSonuc.Text = ortalama.ToString();


            }
        }
    }
}
