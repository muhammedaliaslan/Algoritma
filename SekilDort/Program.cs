using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace SekilDort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi = 5;

            int yildizSayisi = 1;
            int boslukSayisi = sayi - 1;
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




        }
    }
}
