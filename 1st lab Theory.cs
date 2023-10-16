using System;

namespace _1st_Lab
{
    class Program
    {
        void Main(string[] args)
        {
            string v = Console.ReadLine();
            double x = double.Parse(v);
            double s4 = Math.Cos(x);
            for (double i = 1; i <= 8; i++)
                s4 += Math.Cos((i + 1) * x) / Math.Pow(x, i);
            Console.WriteLine("Четвёртое задание:", s4);
        }
    }
}
