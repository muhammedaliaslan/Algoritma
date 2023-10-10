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

namespace Su_Sicakligina_Gore_Durumu
{
    public partial class FrmSuSicakliginaGoreDurumu : Form
    {
        public FrmSuSicakliginaGoreDurumu()
        {
            InitializeComponent();
        }

        private void BtnSonuc_Click(object sender, EventArgs e)
        {
            try
            {

                double sicaklik = 0;
                string durum = "";

                sicaklik = Convert.ToDouble(TxtSuDerecesi.Text);

                if (sicaklik < 0)
                {
                    durum = "Katı";
                }
                else if (sicaklik >= 0 && sicaklik <= 100)
                {
                    durum = "Sıvı";
                }
                else
                {
                    durum = "Gaz";
                }
                MessageBox.Show(durum);

            }
            catch
            {
                MessageBox.Show("Lütfen Geçerli Değer Giriniz !", "HATA !");
            }
        }
    }
}
