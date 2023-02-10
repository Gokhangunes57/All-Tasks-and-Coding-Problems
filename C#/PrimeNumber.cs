using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            
                int Counter = 0;
                Console.WriteLine("Sayıyı Girin");
                int Number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= Number; i++)
                {
                    if (Number % i == 0)
                    {
                        Counter++;
                    }
                }
                if (Counter == 2)
                {
                    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", Number);
                }
                else
                {
                    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", Number);
                }
                Console.ReadKey();
            
        }
    }
}
