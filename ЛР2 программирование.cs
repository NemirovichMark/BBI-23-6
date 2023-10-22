using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛБ2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2 задание 1 уровень
            //int x = int.Parse(Console.ReadLine());
            //int y = int.Parse(Console.ReadLine());
            //if (y >= 0)
            //{
            //    if (y + Math.Abs(x) <= 1)
            //    {
            //        Console.WriteLine("Принадлежит");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Не принадлежит");
            //    }
            //}

            //5 задание 1 уровень
            //Квадрат поместится в круг, если диагональ квадрата меньше или равна диаметру круга
            //double r = double.Parse(Console.ReadLine());
            //double s = double.Parse(Console.ReadLine());
            //double d = Math.Sqrt(2 * s);
            //double rad = Math.Sqrt(r / 3.14);
            //if (d <= rad)
            //{
            //    Console.WriteLine("Поместится");
            //}
            //else
            //{
            //    Console.WriteLine("Не поместится");
            //}

            //8 задание 1 уровень
            //double x = double.Parse(Console.ReadLine());
            //if (Math.Abs(x) >= 1)
            //{
            //    Console.WriteLine("y=" + 0);
            //}
            //if (Math.Abs(x) < 1)
            //{
            //    Console.WriteLine("y=" + (x * x - 1));
            //}

            //задание 2 уровень 2
            //int n = int.Parse(Console.ReadLine());
            //int r = int.Parse(Console.ReadLine());
            //int a = int.Parse(Console.ReadLine());
            //int b = int.Parse(Console.ReadLine());
            //int s = 0;
            //for (int i = 0; i < n; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int y = int.Parse(Console.ReadLine());
            //    if (Math.Sqrt(Math.Pow(2, a - x) + Math.Pow(2, b - y)) <= r)
            //    {
            //        s++;
            //    }
            //}
            //Console.WriteLine(s);

            //5 задание 2 уровень
            //double normmin = double.Parse(Console.ReadLine());
            //double normsec = double.Parse(Console.ReadLine());
            //int s = 0;
            //for (int i = 0;i < 3; i++)
            //{
            //    int xmin = int.Parse(Console.ReadLine());
            //    int ysec = int.Parse(Console.ReadLine());
            //    if (xmin <= normmin)
            //    {
            //        if (ysec <= normsec)
            //        {
            //            s++;
            //        }
            //    }
            //}
            //Console.WriteLine(s);

            //8 задание 2 уровень
            //int n = int.Parse(Console.ReadLine());
            //int nom = 0;
            //double rast = 0;
            //double min = 10000000;
            //for (int i = 1; i < n+1; i++)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    int y = int.Parse(Console.ReadLine());
            //    rast = Math.Sqrt(x * x + y * y);
            //    if (rast < min)
            //    {
            //        nom = i;
            //        min = rast;
            //    }
            //}
            //Console.WriteLine(nom);
            //Console.WriteLine(min);
        }
    }
}
