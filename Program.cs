using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1st_lwl
            // Ex 1
            int s1 = 0;
            for (int i = 2; i <= 35; i += 3)
                s1 += i;
            Console.WriteLine("Ex 1: " + s1);
            Console.WriteLine();

            // Ex 2
            double s2 = 0;
            for (double i = 1; i <= 10; i++)
                s2 += 1 / i;
            Console.WriteLine("Ex 2: " + s2);
            Console.WriteLine();

            // Ex 3
            double s3 = 0;
            for (double i = 2; i <= 112; i += 2)
                s3 += i / i + 1;
            Console.WriteLine("Ex 3: " + s3);
            Console.WriteLine();

            // Ex 4    x = Math.Cos(1)
            string v = Console.ReadLine();
            double x = double.Parse(v);
            double s4 = Math.Cos(x);
            for (double i = 1; i <= 8; i++)
                s4 += Math.Cos((i + 1) * x) / Math.Pow(x, i);
            Console.WriteLine("Ex 4: " + s4);
            Console.WriteLine();

            // Ex 5
            double s5 = 0;
            string str = Console.ReadLine();
            double p = double.Parse(str);
            string str2 = Console.ReadLine();
            double h = double.Parse(str2);
            for (double i = 0; i <= 9; i++)
                s5 += Math.Pow(p + h * i, 2);
            Console.WriteLine("Ex 5: " + s5);
            Console.WriteLine();

            // Ex 6
            Console.WriteLine("Ex 6:");
            for (double i = -4; i <= 4; i++)
            {
                Console.Write(i);
                Console.Write(" ");
                Console.Write(0.5 * Math.Pow(i, 2) - 7 * i);
                Console.WriteLine();
            }
            Console.WriteLine();

            // Ex 7
            double s7 = 1;
            for (int i = 2; i <= 6; i++)
                s7 *= i;
            Console.WriteLine("Ex 7: " + s7);
            Console.WriteLine();

            // Ex 8
            double s8 = 0;
            double f = 1;
            for (double i = 1; i <= 6; i++)
            {
                for (double j = 1; j <= i; j++)
                {
                    f *= j;
                }
                s8 += f;
                f = 1;
            }
            Console.WriteLine("Ex 8: " + s8);
            Console.WriteLine();

            // Ex 9
            double s9 = 0;
            f = 1;
            for (double i = 1; i <= 6; i++)
            {
                for (double j = 1; j <= i; j++)
                {
                    f *= j;
                }
                s9 += Math.Pow(-1, i) * Math.Pow(5, i) / f;
                f = 1;
            }
            Console.WriteLine("Ex 9: " + s9);
            Console.WriteLine();

            // Ex 10
            double s10 = 3;
            for (double i = 2; i<=7; i++)
                s10 *= 3;
            Console.WriteLine("Ex 10: " + s10);
            Console.WriteLine();

            // Ex 11
            Console.WriteLine("Ex 11:");
            for (int i = 1; i <= 6; i++)
                Console.Write(i + " ");
            Console.WriteLine() ;
            for (int i = 1; i <= 6; i++)
                Console.Write("5 ");
            Console.WriteLine();
            Console.WriteLine();

            // Ex 12
            string str12 = Console.ReadLine();
            x = double.Parse(str12);
            double s12 = 1;
            for (int i = 1; i <= 10; i++)
                s12 += 1 / Math.Pow(x, i);
            Console.WriteLine("Ex 12: " + s12);
            Console.WriteLine();

            // Ex 13
            Console.WriteLine("Ex 13: ");

            for (double i = -1.5;  i <= 1.5; i += 0.1)
            { if (i <= -1) Console.WriteLine(i + ": " + 1);
                if (-1 < i & i <= 1) Console.WriteLine(i + ": " + -i);
                if (i > 1) Console.WriteLine(i + ": -1");
            }
            Console.WriteLine();

            // Ex 14
            Console.Write("Ex 14: 1 1 ");
            int[] sp = new int[8];
            sp[0] = sp[1] = 1;
            for (int i = 2; i <= 6; i++)
            {
                sp[i] = sp[i - 1] + sp[i - 2];
                Console.Write(sp[i] + " ");
            }
            Console.WriteLine();

            // Ex 15 add - добавить в массив элемент
            double [] ch = new double[5];
            double[] zn = new double[5];
            ch[0] = 1; ch[1] = 2; zn[0] = zn[1] = 1;
            for (int i = 2; i <= 4; i++)
            {
                ch[i] = ch[i - 1] + ch[i - 2];
                zn[i] = zn[i - 1] + zn[i - 2];
            }
            Console.WriteLine("Ex 15: " + ch[4] + "/" + zn[4]);
        }
    }
}

