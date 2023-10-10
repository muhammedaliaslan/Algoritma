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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace Kullanicidan_Sayi_Al_Ortalama_Yazdir
{
    public partial class FrmKullanicidanSayiAlOrtalamaYazdir : Form
    {
        public FrmKullanicidanSayiAlOrtalamaYazdir()
        {
            InitializeComponent();
        }

        int alinanSayi = 0;
        private void BtnSayiAl_Click(object sender, EventArgs e)
        {
            try
            {

                if (TxtGirilenSayi.Text != "")
                {

                    TxtGirilenSayi.Enabled = false;
                    BtnSayiAl.Enabled = false;

                    alinanSayi = Convert.ToInt32(TxtGirilenSayi.Text);

                    TxtEklenenSayi.Enabled = true;
                    BtnEkle.Enabled = true;
                    BtnYazdir.Enabled = true;
                    AcceptButton = BtnEkle;
                }
                else
                {

                    MessageBox.Show("Lütfen Değer Giriniz", "HATA !");
                }
            }

            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz !");
            }

        }

        int sayac = 0;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {

                if (sayac < alinanSayi)
                {
                    if (TxtEklenenSayi.Text != "")
                    {
                        LstEklenenSayilar.Items.Add(TxtEklenenSayi.Text);
                        sayac++;
                    }
                    else
                    {

                        MessageBox.Show("Lütfen Değer Giriniz", "HATA !");
                    }
                    TxtEklenenSayi.Text = "";

                }
                else
                {
                    BtnEkle.Enabled = false;
                    BtnYazdir.Enabled = true;
                    TxtGirilenSayi.Enabled = false;
                    AcceptButton = BtnYazdir;
                }
            }

            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz !");
            }



        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac == alinanSayi)
                {

                    double sonuc = 0;
                    double ortalama = 0;
                    for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                    {
                        sonuc += Convert.ToDouble(LstEklenenSayilar.Items[i].ToString());

                    }
                    ortalama = Convert.ToDouble(sonuc / alinanSayi);
                    LblSonuc.Text = ortalama.ToString();

                    BtnYazdir.Enabled = true;
                    BtnEkle.Enabled = false;

                    sayac = 0;
                    TxtEklenenSayi.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz !");
            }

        }
    }
}
