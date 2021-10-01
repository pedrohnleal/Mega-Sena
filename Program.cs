using System;

namespace megaSena
{
    class Program
    {
        static void Main(string[] args)
        {
            megasena(1, 60);
        }
        static void megasena(int min, int max)
        {
            Random num = new Random();
            for(int i = 0; i < 6; i++)
            {
                Console.WriteLine(num.Next(min, max));
            }
            Console.ReadLine();
        }
    }
}
