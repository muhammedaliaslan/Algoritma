using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SekilIiki
{
    internal class Program
    {
        static void Main(string[] args)
        {


            for (int i = 0; i < 5; i++)
            {
                for (int j = 5; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.WriteLine("///////////////////");

            int alinanSayi = 0;
            Console.WriteLine("Lütfen Değer Giriniz :");
            alinanSayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < alinanSayi; i++)
            {
                for (int j = alinanSayi; j > i; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Console.Read();

        }
    }
}
