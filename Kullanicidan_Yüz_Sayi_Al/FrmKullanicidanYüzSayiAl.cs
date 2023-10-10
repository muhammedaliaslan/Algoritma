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

namespace Kullanicidan_Yüz_Sayi_Al
{
    public partial class FrmKullanicidanYüzSayiAl : Form
    {
        public FrmKullanicidanYüzSayiAl()
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
                    if (TxtEklenenSayi.Text != "")
                    {
                        LstEklenenSayilar.Items.Add(TxtEklenenSayi.Text);
                        sayac++;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Değer Giriniz", "Hata !");
                    }
                    TxtEklenenSayi.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz!");
            }

        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac == 100)
                {
                    int kucukSayi = 0;
                    int sonuc = 0;

                    kucukSayi = Convert.ToInt32(LstEklenenSayilar.Items[0]);

                    for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                    {
                        sonuc = Convert.ToInt32(LstEklenenSayilar.Items[i]);
                        if (kucukSayi > sonuc)
                        {
                            kucukSayi = sonuc;
                        }
                    }

                    LblSonuc.Text = kucukSayi.ToString();
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz!");
            }

        }
    }
}
