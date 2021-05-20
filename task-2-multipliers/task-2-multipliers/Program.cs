using System;

namespace task_2_multipliers
{
    class Program
    {
        static int NOD(int m, int n)
        {
            while (m != 0 && n != 0)
            {
                if (m > n)
                {
                    m = m % n;
                }
                else
                {
                    n = n % m;
                }
            }
            return m + n;
        }

        static int NOK(int a, int b)
        {
            return a / NOD(a, b) * b;
        }

        static void Main(string[] args)
        {
            int a, b, c;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            c = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("NOD - " + Convert.ToString(NOD(NOD(a, b), c)));
            Console.WriteLine("NOK - " + Convert.ToString(NOK(NOK(a, b), c)));
            Console.ReadLine();
        }
    }
}