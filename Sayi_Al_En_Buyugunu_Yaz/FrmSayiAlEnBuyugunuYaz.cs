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

namespace Sayi_Al_En_Buyugunu_Yaz
{
    public partial class FrmSayiAlEnBuyugunuYaz : Form
    {
        public FrmSayiAlEnBuyugunuYaz()
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
                    alinanSayi = Convert.ToInt32(TxtGirilenSayi.Text);

                    TxtGirilenSayi.Enabled = false;
                    BtnSayiAl.Enabled = false;
                    AcceptButton = BtnEkle;
                    BtnEkle.Enabled = true;
                    TxtEklenenSayi.Enabled = true;
                    TxtGirilenSayi.Enabled = false;
                    BtnSayiAl.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Lütfen Değer Giriniz", "HATA !");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz!");
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

                    if (sayac >= alinanSayi)
                    {
                        BtnEkle.Enabled = false;
                        BtnYazdir.Enabled = true;
                        TxtEklenenSayi.Enabled = false;
                        AcceptButton = BtnYazdir;
                    }
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
                if (sayac == alinanSayi)
                {
                    int buyukSayi = 0;
                    int sonuc = 0;
                    int buyukIndex = 0;

                    buyukSayi = Convert.ToInt32(LstEklenenSayilar.Items[0]);

                    for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                    {
                        sonuc = Convert.ToInt32(LstEklenenSayilar.Items[i]);
                        if (buyukSayi < sonuc)
                        {
                            buyukSayi = sonuc;
                            buyukIndex = i;
                        }
                    }
                    LblSonuc.Text = buyukSayi.ToString();
                    LstEklenenSayilar.SelectedIndex = buyukIndex;
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz!");
            }
        }
    }
}
