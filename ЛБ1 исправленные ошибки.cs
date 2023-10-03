using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _30._09._23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1 уровень 1 задача
            //int sum = 0;
            //for (int i = 2; i < 38; i += 3)
            //{
            //    sum = sum + i;
            //}
            //Console.WriteLine(sum);

            //1 уровень 3 задача
            //double A = 0;
            //for (double i = 2; i <= 112; i += 2)
            //{
            //    A += (i / (i + 1));
            //}
            //Console.WriteLine(A);

            //1 уровень 4 задача
            //double sum = 0;
            //int x = 10;
            //for (int i = 0; i <= 8; i += 1)
            //{
            //    sum += Math.Cos((i + 1) * x) / Math.Pow(x, i-1);
            //}
            //Console.WriteLine(sum);

            //1 уровень 5 задача
            //int p = 1;
            //double sum = 0;
            //for (int h = 0; h <= 9; h++)
            //{
            //    int ph = p + h;
            //    sum += Math.Pow(ph, 2);
            //}
            //Console.WriteLine(sum);

            //1 уровень 6 задача
            //double number = 0;
            //for (double i = -4; i <= 4; i += 0.5)
            //{
            //    number = ((0.5 * Math.Pow(i, 2)) - 7 * i);
            //    Console.WriteLine($"{number} {i}");
            //}

            //1 уровень 9 задача
            //int Factorial(int n)
            //{
            //    if (n == 1) return 1;

            //    return n * Factorial(n - 1);
            //}

            //int sum = 0;
            //int number = 0;

            //for (int i = 1; i <= 6; i++)
            //{
            //    number = (int)(Math.Pow(-1, i) * Math.Pow(5, i) / Factorial(i));
            //    sum += number;
            //}
            //Console.WriteLine(number);

            //1 уровень 12 задача
            //double sum = 0;
            //int x = 2;
            //for (int i = 0; i <= 10; i++)
            //{
            //    sum += 1 / Math.Pow(x, i);
            //}
            //Console.WriteLine(sum);

            //1 уровень 13 задача
            //Console.WriteLine("x     y");
            //double y13 = 0;
            //for (double x13 = -1.5; x13 < 1.6; x13 += 0.1)
            //{
            //    if (x13 <= -1) y13 = 1;
            //    else if (x13 > -1 && x13 <= 1)
            //    {
            //        if (x13 == 0) y13 = 0;
            //        else y13 = -x13;
            //    }
            //    else if (x13 > 1) y13 = -1;

            //    Console.WriteLine($"{Math.Round(x13, 2)}    {Math.Round(y13, 2)}");
            //}

            //1 уровень 14 задача
            //int n = 8;
            //int first = 1;
            //int second = 1;

            //Console.Write(first + " " + second + " ");

            //for (int i = 3; i <= n; i++)
            //{
            //    int next = first + second;
            //    Console.Write(next + " ");

            //    first = second;
            //    second = next;
            //}

            //1 уровень 15 задача
            //int n = 5;

            //int numerator1 = 1;
            //int denominator1 = 1;

            //int numerator2 = 2;
            //int denominator2 = 1;

            //int numerator = 0;
            //int denominator = 0;

            //for (int i = 3; i <= n; i++)
            //{
            //    numerator = numerator1 + numerator2;
            //    denominator = denominator1 + denominator2;


            //    numerator1 = numerator2;
            //    denominator1 = denominator2;
            //    numerator2 = numerator;
            //    denominator2 = denominator;
            //}

            //Console.WriteLine("5-й член последовательности: " + (double)numerator / denominator);
            //Console.ReadKey();

            //2 уровень 1 задача
            //double x = 0.5;
            //double epsilon = 0.0001;
            //double sum = 0;
            //double term = 1;
            //double n = 1;

            //while (Math.Abs(term) >= epsilon)
            //{
            //    sum += term;
            //    n++;
            //    term = Math.Cos(n * x) / (n * n);
            //}

            //Console.WriteLine("Сумма ряда: " + sum);

            //2 уровнь 4 задача
            //double sum = 0;
            //double x = 0.9;
            //double last_sum = 0;
            //for (int n = 1; n <= 10000; n++)
            //{
            //    sum += Math.Pow(x, n * 2);
            //    if (Math.Pow(x, n * 2) >= 0.0001)
            //    {
            //        last_sum = sum;
            //    }

            //    if (Math.Pow(x, n * 2) < 0.0001)
            //    {
            //        Console.WriteLine(last_sum);
            //        break;
            //    }
            //}
        }
    }
}
