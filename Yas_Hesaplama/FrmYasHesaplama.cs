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

namespace Yas_Hesaplama
{
    public partial class FrmYasHesaplama : Form
    {
        public FrmYasHesaplama()
        {
            InitializeComponent();
        }

        private void BtnHesapla_Click(object sender, EventArgs e)
        {

            int yas = 0;
            DateTime dogumTarihi = DateTime.Now; ;
            TimeSpan fark=TimeSpan.Zero;

            dogumTarihi = dateTimePicker1.Value;
            fark = DateTime.Now.Date.Subtract(dogumTarihi);
            yas = Convert.ToInt32(fark.TotalDays);
            yas = yas / 365;
            LblYas.Text = yas.ToString();




        }
    }
}
