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

namespace Bes_Sayi_Al_Topla
{
    public partial class FrmBesSayiAlTopla : Form
    {
        public FrmBesSayiAlTopla()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void BtnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (sayac < 5)
                {



                    if (TxtEkle.Text != "")
                    {
                        LstEklenenSayilar.Items.Add(TxtEkle.Text);
                        sayac++;
                    }
                    else
                    {
                        MessageBox.Show("LÜTFEN VERİ GİRİNİZ..!   ", " HATA!!!");
                    }
                    TxtEkle.Text = "";

                }
                if (sayac > 4)
                {
                    BtnEkle.Visible = false;
                    BtnTopla.Enabled = true;
                    TxtEkle.Visible = false;
                    AcceptButton = BtnTopla;
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz.");
            }

        }

        private void BtnTopla_Click(object sender, EventArgs e)
        {

            if (sayac == 5)
            {
                int sonuc = 0;
                for (int i = 0; i < LstEklenenSayilar.Items.Count; i++)
                {
                    sonuc += Convert.ToInt32(LstEklenenSayilar.Items[i].ToString());

                }
                LblSonucYaz.Text = sonuc.ToString();
                BtnEkle.Enabled = true;
                BtnTopla.Enabled = false;
                //LstEklenenSayilar.Items.Clear();
                sayac = 0;
                TxtEkle.Text = "";
            }
        }

    }
}

