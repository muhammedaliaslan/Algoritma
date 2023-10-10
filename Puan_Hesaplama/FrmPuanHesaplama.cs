using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Puan_Hesaplama
{
    public partial class FrmPuanHesaplama : Form
    {
        public FrmPuanHesaplama()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {
            int sinavNot1 = 0;
            int sinavNot2 = 0;
            int sinavNot3 = 0;

            int sonuc = 0;
            double ortalamaNotu = 0;
            try
            {
                sinavNot1 = Convert.ToInt32(TxtSinavBir.Text);
                sinavNot2 = Convert.ToInt32(TxtSinavIki.Text);
                sinavNot3 = Convert.ToInt32(TxtSinavUc.Text);

                if (sinavNot1 >= 0 && sinavNot1 <= 100 && sinavNot2 >= 0 && sinavNot2<= 100 && sinavNot3 >= 0 && sinavNot3 <= 100)
                {
                    ortalamaNotu = (sinavNot1 + sinavNot2 + sinavNot3) / 3.0;

                    sonuc = (int)Math.Round(ortalamaNotu / 20);

                    LblSonuc.Text = sonuc.ToString();
                }
                else
                {
                    MessageBox.Show("Lütfen geçerli bir not girin (0-100 aralığında).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }

                
                



                
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli bir not girin (0-100 aralığında).", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }
    }
}
