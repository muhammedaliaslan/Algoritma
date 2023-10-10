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

namespace Otuz_Sayi_Al_Ortalama_Yazdir
{
    public partial class FrmOtuzSayiAlOrtalamaYazdir : Form
    {
        public FrmOtuzSayiAlOrtalamaYazdir()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac < 30)
                {
                    if (TxtEklenenSayi.Text != "")
                    {
                        LstEklenenSayilar.Items.Add(TxtEklenenSayi.Text);
                        sayac++;
                    }
                    else
                    {

                        MessageBox.Show("Lütfen Değer Giriniz...", "HATA !");
                    }
                    TxtEklenenSayi.Text = "";


                    if (sayac > 29)
                    {
                        BtnEkle.Visible = false;
                        BtnYazdir.Visible = true;
                        TxtEklenenSayi.Visible = false;
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
                if (sayac == 30)
                {
                    double sonuc = 0;
                    double ortalama = 0;
                    for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                    {
                        sonuc += Convert.ToDouble(LstEklenenSayilar.Items[i].ToString());

                    }
                    ortalama = Convert.ToDouble(sonuc / 30);
                    LblSonuc.Text = ortalama.ToString();

                    BtnEkle.Enabled = true;
                    BtnYazdir.Enabled = false;

                    sayac = 0;
                    TxtEklenenSayi.Text = "";
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz!");
            }

        }
    }
}
