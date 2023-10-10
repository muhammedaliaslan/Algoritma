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

namespace Tam_Sayi_Kontrolu
{
    public partial class FrmTamSayiKontrolu : Form
    {
        public FrmTamSayiKontrolu()
        {
            InitializeComponent();
        }

        private void BtnSonuc_Click(object sender, EventArgs e)
        {
            try
            {
                int sayi = 0;
                sayi = Convert.ToInt32(TxtSayiGiriniz.Text);
                if (sayi == 0)
                {
                    MessageBox.Show("Sıfır", "Durum");
                }
                else if (sayi >= 0)
                {
                    MessageBox.Show("Pozitif", "Durum");
                }
                else
                {
                    MessageBox.Show("Negatif", "Durum");
                }
            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz.");
            }

        }
    }
}
