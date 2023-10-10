using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanicininGiridiğiSayidanKucukFibonacciDizisi
{
    public partial class FrmKullanicininGiridiğiSayidanKucukFibonacciDizisi : Form
    {
        public FrmKullanicininGiridiğiSayidanKucukFibonacciDizisi()
        {
            InitializeComponent();
        }

        private void btnYazdir_Click(object sender, EventArgs e)
        {
            int limit=0;
            
            if (int.TryParse(txtLimit.Text, out limit))
            {
                string fibonacciDizisi = "";
                int a = 0;
                int b = 1;
                int c = 0;

                while (c < limit)
                {
                    fibonacciDizisi += c.ToString() + " ";
                    a = b;
                    b = c;
                    c = a + b;
                }

                lstListele.Items.Add(fibonacciDizisi);
            }
            else
            {
                MessageBox.Show("Geçerli bir sayı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
