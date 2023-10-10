using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanicidanIkiSayiAlCiftSayilariBuyuktenKucugeYaz
{
    public partial class FrmKullanicidanIkiSayiAlCiftSayilariBuyuktenKucugeYaz : Form
    {
        public FrmKullanicidanIkiSayiAlCiftSayilariBuyuktenKucugeYaz()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            try
            {
                int ilkSayi = 0;
                int ikinciSayi = 0;

                ilkSayi = Convert.ToInt32(txtSayiBir.Text);

                ikinciSayi = Convert.ToInt32(txtSayiIki.Text);


                int baslangic = 0;
                int bitis = 0;

                if (ilkSayi < ikinciSayi)
                {
                    baslangic = ikinciSayi;
                    bitis = ilkSayi;
                }
                else
                {
                    baslangic = ilkSayi;
                    bitis = ikinciSayi;
                }

                for (int i = baslangic; i >= bitis; i--)
                {
                    if (i % 2 == 0)
                    {
                        lstYazdirilanSayilar.Items.Add(i);
                    }
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz.");
            }
            
        }
    }
}
