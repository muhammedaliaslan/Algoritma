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

namespace Bin_Sayi_Al_Yazdir
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
                if (sayac < 1000)
                {
                    if (TxtAlinanSayi.Text != "")
                    {
                        LstEklenenSayilar.Items.Add(TxtAlinanSayi.Text);
                        sayac++;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen Değer Giriniz", "Hata");
                    }
                    TxtAlinanSayi.Text = "";

                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz");
            }
            
        }
    }
}
