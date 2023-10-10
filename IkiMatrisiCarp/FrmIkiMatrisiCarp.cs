using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IkiMatrisiCarp
{
    public partial class FrmIkiMatrisiTopla : Form
    {
        public FrmIkiMatrisiTopla()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int aMatrisBir = 0;
                int aMatrisIki = 0;

                int bMatrisBir = 0;
                int bMatrisIki = 0;

                int aCarpiBSonucBir = 0;
                int aCarpiBSonucIki = 0;

                aMatrisBir = Convert.ToInt32(txtAMatrisBir.Text);
                aMatrisIki = Convert.ToInt32(txtAMatrisIki.Text);

                bMatrisBir = Convert.ToInt32(txtBMatrisBir.Text);
                bMatrisIki = Convert.ToInt32(txtBMatrisIki.Text);

                aCarpiBSonucBir = aMatrisBir * bMatrisBir;
                aCarpiBSonucIki = aMatrisIki * bMatrisIki;

                txtACarpimBMatrisBir.Text = aCarpiBSonucBir.ToString();
                txtACarpimBMatrisIki.Text = aCarpiBSonucIki.ToString();
            }
            catch
            {
                MessageBox.Show("Lütfen geçerli değer giriniz.");
            }
        }
    }
}
