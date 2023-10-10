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

namespace Tekleri_Ciftleri_Ayri_Yazma
{
    public partial class FrmTekleriCiftleriAyriYazma : Form
    {
        public FrmTekleriCiftleriAyriYazma()
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

                    TxtEklenenSayi.Enabled = true;
                    BtnEkle.Enabled = true;

                    AcceptButton = BtnEkle;

                    TxtGirilenSayi.Enabled = false;
                    BtnSayiAl.Enabled = false;

                }
                else
                {
                    MessageBox.Show("Lütfen Değer Giriniz !");
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
                    if (TxtEklenenSayi.Text == "")
                    {
                        MessageBox.Show("Lütfen Değer Giriniz", "HATA !");
                    }
                    else
                    {
                        LstEklenenSayilar.Items.Add(TxtEklenenSayi.Text);
                        sayac++;
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
                    int sayi = 0;


                    for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                    {
                        sayi = Convert.ToInt32(LstEklenenSayilar.Items[i]);
                        if (sayi % 2 == 1)
                        {
                            LstTekler.Items.Add(sayi);
                        }
                        else
                        {
                            LstCiftler.Items.Add(sayi);
                        }
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz!");
            }

        }
    }
}
