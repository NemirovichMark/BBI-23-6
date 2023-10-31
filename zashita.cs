using System;

namespace ConsoleApp1
{
    internal class Program2
    {
        static void Main(string[] args)
        {
           
            double norma = Convert.ToDouble(Console.ReadLine());
            string res = Console.ReadLine();
            int count1 = 0;
            int count2 = 0;
            int count3 = 0;

            double result = 0;
            while (res != "stop")
            {
                if (res == "-" || res == " ")
                {
                    ++count3;
                }
                else
                {
                    result = Convert.ToDouble(res);
                    if (result >= norma)
                    {
                        ++count1;
                    }
                    else
                    {
                        ++count2;
                    }
                }
                
                res = Console.ReadLine();
            }
            Console.WriteLine(count1);
            Console.WriteLine(count2);
            Console.WriteLine(count3);
        }
    }
}
