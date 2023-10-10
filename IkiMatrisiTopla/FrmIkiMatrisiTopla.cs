using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkiMatrisiTopla
{
    public partial class FrmIkiMatrisiTopla : Form
    {
        public FrmIkiMatrisiTopla()
        {
            InitializeComponent();
        }



        private void btnHesapla_Click_1(object sender, EventArgs e)
        {
            try
            {
                int aMatrisBir = 0;
                int aMatrisIki = 0;

                int bMatrisBir = 0;
                int bMatrisIki = 0;

                int aArtiBSonucBir = 0;
                int aArtiBSonucIki = 0;

                aMatrisBir = Convert.ToInt32(txtAMatrisBir.Text);
                aMatrisIki = Convert.ToInt32(txtAMatrisIki.Text);

                bMatrisBir = Convert.ToInt32(txtBMatrisBir.Text);
                bMatrisIki = Convert.ToInt32(txtBMatrisIki.Text);

                aArtiBSonucBir = aMatrisBir + bMatrisBir;
                aArtiBSonucIki = aMatrisIki + bMatrisIki;

                txtAArtiBMatrisBir.Text = aArtiBSonucBir.ToString();
                txtAArtiBMatrisIki.Text = aArtiBSonucIki.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli değer giriniz.");
            }
        }
    }
}
