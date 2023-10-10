using Kullanicidan_Sayi_Al_Bitince_Ortalama_Yaz;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kullanicidan_Sayi_Al_Ortalama_Yazdir
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FrmKullanicidanSayiAlBitinceOrtalamaYaz());
        }
    }
}
