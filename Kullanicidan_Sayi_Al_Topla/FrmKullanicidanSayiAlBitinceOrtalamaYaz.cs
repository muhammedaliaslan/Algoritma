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

namespace Kullanicidan_Sayi_Al_Bitince_Ortalama_Yaz
{
    public partial class FrmKullanicidanSayiAlBitinceOrtalamaYaz : Form
    {
        public FrmKullanicidanSayiAlBitinceOrtalamaYaz()
        {
            InitializeComponent();
        }




        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtEklenenSayi.Text != "")
                {
                    LstEklenenSayilar.Items.Add(TxtEklenenSayi.Text);

                }
                else
                {
                    MessageBox.Show("Lütfen Değer Giriniz", "HATA !");
                }
                TxtEklenenSayi.Text = "";
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
                double sonuc = 0;
                double ortalama = 0;

                for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                {
                    sonuc += Convert.ToDouble(LstEklenenSayilar.Items[i].ToString());

                }
                ortalama = sonuc / LstEklenenSayilar.Items.Count;
                LblSonuc.Text = ortalama.ToString();

                BtnEkle.Enabled = false;
            }
            catch
            {
                
            }

        }


    }
}
