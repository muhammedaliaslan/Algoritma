using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KullanicidanYirmiTaneDogumTarihiAlYasOrtalamasiHesapla
{
    public partial class FrmKullanicidanYirmiTaneDogumTarihiAlYasOrtalamasiHesapla : Form
    {
        public FrmKullanicidanYirmiTaneDogumTarihiAlYasOrtalamasiHesapla()
        {
            InitializeComponent();
        }

        int sayac = 0;
        private void btnYasEkle_Click(object sender, EventArgs e)
        {
            if (sayac < 20)
            {
                int yas = 0;
                DateTime dogumTarihi = DateTime.Now; ;
                TimeSpan fark = TimeSpan.Zero;

                dogumTarihi = dtmTarihSec.Value;
                fark = DateTime.Now.Date.Subtract(dogumTarihi);
                yas = Convert.ToInt32(fark.TotalDays);
                yas = yas / 365;
                lstYaslar.Items.Add(yas);
                sayac++;
            }
            if (sayac == 20)
            {
                dtmTarihSec.Enabled= false;
                btnYasEkle.Enabled= false;
            }
            
           
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            if (sayac == 20)
            {

                double sonuc = 0;
                double ortalama = 0;
                for (int i = 0; i < lstYaslar.Items.Count; i++)
                {
                    sonuc += Convert.ToDouble(lstYaslar.Items[i].ToString());

                }
                ortalama = Convert.ToDouble(sonuc / 20);
                lblOrtalama.Text = ortalama.ToString();
            }
        }
    }
}
