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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Elli_Sayial_Buyuk_Cift_Sayi_Yaz
{
    public partial class FrmElliSayiAlBuyukCiftSayiyiYaz : Form
    {
        public FrmElliSayiAlBuyukCiftSayiyiYaz()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac < 50)
                {
                    if (TxtEklenenSayilar.Text != "")
                    {


                        LstEklenenSayilar.Items.Add(TxtEklenenSayilar.Text);
                        sayac++;

                        TxtEklenenSayilar.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Değer Giriniz", "HATA !");
                    }
                    TxtEklenenSayilar.Text = "";

                    if (sayac > 49)
                    {


                        TxtEklenenSayilar.Visible = false;
                        BtnEkle.Enabled = false;
                        AcceptButton = BtnYazdir;
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz.");
            }




        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac == 50)
                {
                    int sayi = 0;
                    int buyukSayi = 0;
                    int sayiIndex = 0;

                    buyukSayi = Convert.ToInt32(LstEklenenSayilar.Items[0]);

                    for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                    {
                        sayi = Convert.ToInt32(LstEklenenSayilar.Items[i]);
                        if (buyukSayi < sayi && sayi % 2 == 0)
                        {
                            buyukSayi = sayi;
                            sayiIndex = i;
                        }

                    }
                    LblSonuc.Text = buyukSayi.ToString();
                    LstEklenenSayilar.SelectedIndex = sayiIndex;
                }
            }
            catch
            {
                MessageBox.Show("Girilen Değerleri Kontrol Ediniz.");
            }


        }
    }
}

