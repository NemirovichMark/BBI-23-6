using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region
            double s = 0;
            int p = Int32.Parse(Console.ReadLine());
            int h = Int32.Parse(Console.ReadLine());
            for (int i = 0; i <= 9; i++)
            {
                s += Math.Pow((p + h * i), 2);
            }
            Console.WriteLine(s);
            #endregion
        }
    }
}
