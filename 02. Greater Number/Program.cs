using System;

namespace _02._Greater_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numer1 = int.Parse(Console.ReadLine());
            int numer2 = int.Parse(Console.ReadLine());

            if (numer1 >= numer2)
            {
                Console.WriteLine(numer1);
            }
            else
            {
                Console.WriteLine(numer2);
            }

        }
    }
}
