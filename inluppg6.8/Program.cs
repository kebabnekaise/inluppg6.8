using System;

namespace inluppg6_8
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett tal");
            int tal = int.Parse(Console.ReadLine());

            int primCounter = 0;
            for (int i = 1; i < tal; i += 2)
            {
                if (isPrimtal(i))
                {
                    primCounter++;
                }
            }
            Console.WriteLine($"Det finns {primCounter} primtal mindre än {tal}");
        }

        static bool isPrimtal(int x)
        {
            if (x == 1)
            {
                return true;
            }
            else if (x == 2)
            {
                return true;
            }


            if (x % 2 == 0)
            {
                return false;
            }
            for (int i = 3; i < x; i += 2)
            {
                if (x % i == 0)
                {
                    return false;
                }
            }


            return true;
        }
    }
}