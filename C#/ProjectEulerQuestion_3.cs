/* Question 3: Project euler
The prime factors of 13195 are 5, 7, 13 and 29.
What is the largest prime factor of the number 600851475143 ?
*/






namespace ProjectEuler_LargestPrimeFactor
{
    class Program
    {
        static long numberToFactor = 600851475143;

        static void Main(string[] args)
        {
            Console.WriteLine(LargestPrimeFactorOf(numberToFactor) + " is the largest prime factor of " + numberToFactor);
            Console.ReadKey();
        }

        static long LargestPrimeFactorOf(long n)
        {
            long lastPrimeFactor = 0;

            for (long i = 2; i < n; i++)
            {
                if (isPrime(i) && n % i == 0)
                {
                    lastPrimeFactor = i;
                    Console.WriteLine(i + " is a prime factor of " + n);
                }
            }

            return lastPrimeFactor;
        }

        static bool isPrime(long n)
        {
            if (n == 2) return true;
            if ((n > 2 && n % 2 == 0) || n == 1) return false;

            for (long i = 2; i <= Math.Floor(Math.Sqrt(n)); ++i)
            {
                if (n % i == 0) return false;
            }

            return true;
        }
    }
}





