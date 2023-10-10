using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanicidanSayiAlTekseCarpCiftseTopla
{
    public partial class FrmKullanicidanSayiAlTekseCarpCiftseTopla : Form
    {
        public FrmKullanicidanSayiAlTekseCarpCiftseTopla()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEklenenSayi.Text != "")
                {
                    lstEklenenSayilar.Items.Add(txtEklenenSayi.Text);
                }
                else
                {
                    MessageBox.Show("Lütfen Geçerli Değer Giriniz");
                }
                txtEklenenSayi.Text = "";
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
                int sonuc = 1;

                int sayiDurum = 0;


                for (int i = 0; i < lstEklenenSayilar.Items.Count; i++)
                {
                    sayiDurum = Convert.ToInt32(lstEklenenSayilar.Items.Count.ToString());
                }

                if (sayiDurum % 2 == 0)
                {
                    for (int i = 0; i < lstEklenenSayilar.Items.Count; i++)
                    {
                        sonuc *= Convert.ToInt32(lstEklenenSayilar.Items[i].ToString());

                    }
                }
                else
                {

                    for (int i = 0; i < lstEklenenSayilar.Items.Count; i++)
                    {
                        sonuc += Convert.ToInt32(lstEklenenSayilar.Items[i].ToString());

                    }

                }
                lblSonuc.Text = sonuc.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz !");
            }
            



        }
    }
}
