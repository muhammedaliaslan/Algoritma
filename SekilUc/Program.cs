using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilUc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int sayi = 5;

            int yildizSayisi = 1;
            int boslukSayisi = 4;
            for (int i = 0; i < sayi; i++)
            {
                for (int j = 0; j < boslukSayisi; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < yildizSayisi; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < boslukSayisi; j++)
                {
                    Console.Write(" ");
                }
                boslukSayisi--;
                yildizSayisi += 2;
                Console.WriteLine();
            }
            Console.ReadLine();

            //////////////////
            //////////////////
            
            int alinanSayi = 0;
            Console.WriteLine("Lütfen Değer Girin :");
            alinanSayi = Convert.ToInt32(Console.ReadLine());
            int yildiz = 1;
            int bosluk = 0;

            bosluk = alinanSayi - 1;

            for (int i = 0; i < alinanSayi; i++)
            {
                for (int j = 0; j < bosluk; j++)
                {
                    Console.Write(" ");
                }
                for (int j = 0; j < yildiz; j++)
                {
                    Console.Write("*");
                }
                for (int j = 0; j < bosluk; j++)
                {
                    Console.Write(" ");
                }
                bosluk--;
                yildiz += 2;
                Console.WriteLine();
            }
            Console.ReadLine();

        }
    }
}
