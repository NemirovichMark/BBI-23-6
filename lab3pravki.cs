using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
namespace _3_лаба
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1/1

            //double[] a = new double[6];
            //string s;
            //for (int i = 0; i < 6; i++)
            //{
            //    s = Console.ReadLine();
            //    a[i] = double.Parse(s);
            //}
            //double sum = 0;
            //for (int i = 0; i < 6; i++)
            //{
            //    sum += a[i];
            //}
            //Console.WriteLine(sum);
            //if (sum != 0)
            //{
            //    for (int i = 0; i < 6; i++)
            //    {
            //        a[i] /= sum;
            //    }
            //    Console.WriteLine("Массив после деления: ");
            //    for (int i = 0; i < 6; i++)
            //    {
            //        Console.WriteLine(a[i]);
            //    }
            //}
            //1/15
            //double[] x = new double[10];
            //double[] y = new double[10];
            //string k;
            //Console.WriteLine("Введите массив x");
            //for (int i = 0; i < 10; i++)
            //{
            //    k = Console.ReadLine();
            //    x[i] = double.Parse(k);
            //}
            //for (int i = 0; i < 10; i++)
            //{
            //    y[i] = 0.5 * Math.Log(x[i]);
            //}
            //Console.WriteLine(" ");
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{x[i]} {y[i]}");
            //}
            //2/7
            //double[] a = new double[7];
            //string k;
            //double sum = 0;
            //int m = 0;
            //double sr;
            //Console.WriteLine("Введите массив a");
            //for (int i = 0; i < 7; i++)
            //{
            //    k = Console.ReadLine();
            //    a[i] = double.Parse(k);
            //}
            //for (int i = 0; i < 7; i++)
            //{
            //    sum = sum + a[i];
            //    m += 1;
            //}
            //sr = sum / m;
            //Console.WriteLine("Среднее арифметическое");
            //Console.WriteLine(sr);
            //for (int i = 0; i < 7; i++)
            //{
            //    if (a[i] > sr)
            //    {
            //        a[i] = 0;
            //    }
            //}
            //Console.WriteLine("Измененный массив");
            //for (int i = 0; i < 7; i++)
            //{
            //    Console.WriteLine(a[i]);
            //}
            //2/9
            //double[] a = new double[8];
            //string k;
            //double sum = 0;
            //int m = 0;
            //int n = 0;
            //double sr;
            //Console.WriteLine("Введите массив a");
            //for (int i = 0; i < 8; i++)
            //{
            //    k = Console.ReadLine();
            //    a[i] = double.Parse(k);
            //}
            //for (int i = 0; i < 8; i++)
            //{
            //    sum = sum + a[i];
            //    m += 1;
            //}
            //sr = sum / m;
            //Console.WriteLine("Среднее арифметическое");
            //Console.WriteLine(sr);
            //for (int i = 0; i < 8; i++)
            //{
            //    if (a[i] > sr)
            //    {
            //        n += 1;
            //    }
            //}
            //Console.WriteLine("Кол-во элементов, больших sr");
            //Console.WriteLine(n);

            //// номер 2/11
            //int number = int.Parse(Console.ReadLine());

            //double[] numbers = new double[number];

            //double P = Convert.ToDouble(Console.ReadLine());

            //for (int i = 0; i < number; i++)
            //{
            //    numbers[i] = Convert.ToDouble(Console.ReadLine());
            //}

            //int last_index = 0;
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    if (numbers[i] > 0)
            //    {
            //        last_index = i;
            //    }
            //}

            //double[] new_list = new double[number + 1];
            //if (last_index >= 0)
            //{
            //    for (int i = 0; i < number + 1; i++)
            //    {
            //        if (i != last_index)
            //        {
            //            new_list[i] = numbers[i];
            //        }
            //        else
            //        {
            //            new_list[i] = P;
            //        }
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("В массиве нет положительных элементов.");
            //}

            //for (int i = 0; i < number + 1; i++)
            //{
            //    Console.Write(number + " ");
            //}
            //Console.ReadKey();

            //2/20
            //    int[] mas = { 2, -56, 49, -3, 7, -33 };

            //    double firstotr = 100;
            //    int indexotr = 0;
            //    double minel = 100;
            //    int indexmin = 0;
            //    double sumchet = 0;
            //    double sumnech = 0;

            //    for (int i = 0; i < 6; i++)
            //    {
            //        if (mas[i] < 0)
            //        {
            //            indexotr = i;
            //            break;
            //        }
            //    }
            //    for (int i = 0; i < 6; i++)
            //    {
            //        if (mas[i] < minel)
            //        {
            //            minel = mas[i];
            //            indexmin = i;
            //        }
            //    }
            //    if (indexotr < indexmin)
            //    {
            //        for (int i = 0; i < 6; i += 2)
            //        {
            //            sumchet += mas[i];
            //        }
            //        Console.WriteLine(sumchet);
            //    }
            //    else
            //    {
            //        for (int i = 1; i < 6; i += 2)
            //        {
            //            sumnech += mas[i];
            //        }
            //        Console.WriteLine(sumnech);

            //    }
            //3/2
            Console.WriteLine("Введите n: ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите массив: ");
            int[] a = new int[n];

            for (int i = 0; i < n; i++)
            {
                string s = Console.ReadLine();
                a[i] = int.Parse(s);
            }
            int amax = a[0];
            int imax = 0;
            int m = 0;
            for (int i = 0; i < n; i++)
            {
                if (a[i] > amax)
                {
                    amax = a[i];
                }
            }
            for (int i = 0; i < n; i++)
            {
                if (a[i] == amax)
                {
                    m++;
                    a[i] += m;
                }
            }
            Console.WriteLine("Полученный массив: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(a[i]);
            }

        }




    }
}