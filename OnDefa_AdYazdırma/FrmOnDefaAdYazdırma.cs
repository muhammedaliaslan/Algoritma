using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnDefa_AdYazdırma
{
    public partial class FrmOnDefaAdYazdırma : Form
    {
        public FrmOnDefaAdYazdırma()
        {
            InitializeComponent();
        }

        private void BtnYazdir_Click(object sender, EventArgs e)
        {
            for (int i = 1; i <= 10; i++)
            {
                LstOnDefaAdYazdirma.Items.Add(i + " Muhammed Ali");
            }
        }
    }
}
