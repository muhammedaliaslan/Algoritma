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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Ortalama_Altinda_Olanlari_Yaz
{
    public partial class FrmOrtalamaAltindaOlanlariYaz : Form
    {
        public FrmOrtalamaAltindaOlanlariYaz()
        {
            InitializeComponent();
        }

        int girilenSayi = 0;
        private void BtnSayiAl_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtGirilenSayi.Text != "")
                {
                    girilenSayi = Convert.ToInt32(TxtGirilenSayi.Text);
                    TxtEklenenSayi.Enabled = true;
                    BtnEkle.Enabled = true;

                    TxtGirilenSayi.Enabled = false;
                    BtnSayiAl.Enabled = false;

                    AcceptButton = BtnEkle;
                }
                else
                {
                    MessageBox.Show("Lütfen Değer Giriniz!");

                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz");
            }
            
        }

        int sayac = 0;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac < girilenSayi)
                {
                    if (TxtEklenenSayi.Text != "")
                    {
                        LstEklenenSayilar.Items.Add(TxtEklenenSayi.Text);
                        sayac++;

                    }
                    else
                    {

                        MessageBox.Show("Lütfen Değer Giriniz!");
                    }

                }
                else
                {
                    TxtEklenenSayi.Enabled = false;
                    BtnEkle.Enabled = false;

                    BtnYazdir.Enabled = true;
                    AcceptButton = BtnYazdir;
                }
                TxtEklenenSayi.Text = "";
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

                if (sayac == girilenSayi)
                {
                   

                    double sonuc = 0;
                    double ortalama = 0;

                    double kucukSayi = 0;
                    kucukSayi = Convert.ToDouble(LstEklenenSayilar.Items[0]);

                    for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                    {
                        sonuc += Convert.ToDouble(LstEklenenSayilar.Items[i].ToString());

                    }
                    ortalama = Convert.ToDouble(sonuc / girilenSayi);   

                    int sayi = 0;
                    for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                    {
                        sayi = Convert.ToInt32(LstEklenenSayilar.Items[i]);
                        if (sayi < ortalama)
                        {
                            LstSonuc.Items.Add(sayi);
                        }
                    }

                }

            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz");
            }
        }
    }
}
