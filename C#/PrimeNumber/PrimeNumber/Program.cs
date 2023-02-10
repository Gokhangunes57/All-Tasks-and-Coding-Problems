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
            while(true)
            {
                int Counter = 0;
                Console.WriteLine("Entry the number");
                int number1 = Convert.ToInt32(Console.ReadLine());
                for (int i = 1; i <= number1; i++)
                {
                    if (number1 % i == 0)
                    {
                        Counter++;
                    }
                }
                if (Counter == 2)
                {
                    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayıdır.", number1);
                }
                else
                {
                    Console.WriteLine("Girdiğiniz {0} sayısı Asal Sayı Değildir.", number1);
                }
                Console.ReadKey();
            }
           

        }
    }
}
