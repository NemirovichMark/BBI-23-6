// номер по списку 19

// I уровень, задание №2 
//using System;
//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double x, y;
//        bool l = false;
//        Console.WriteLine("Введите х");
//        x = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите y");
//        y = double.Parse(Console.ReadLine());
//        if (y >= 0 && y + Math.Abs(x) <= 1 ) l = !l;
//        Console.WriteLine(l);
//    }
//}

// задание №8
//using System;
//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double x, y;
//        Console.WriteLine("Введите x");
//        x = double.Parse(Console.ReadLine());
//        if (Math.Abs(x) > 1)
//        {
//            y = 0;
//        }
//        else
//        {
//             y=x*x-1;
//        }
//        Console.WriteLine(y);
//    }
//}

// задание №5
//using System;
//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double sa, sr, a, r, d;
//        Console.WriteLine("Ввдеите площадь круга");
//        sr = double.Parse(Console.ReadLine());
//        Console.WriteLine("Ввдеите площадь квадрата");
//        sa = double.Parse(Console.ReadLine());
//        a = Math.Sqrt(2 * sa);
//        r = Math.Sqrt(sr / Math.PI);
//        d = 2 * r;
//        if (d >= a)
//        {
//            Console.WriteLine("True");
//        }
//        else
//        {
//            Console.WriteLine("False");
//        }
//    }
//}

// II уровень номер 2
//using System;
//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        double n, r, a, b, x, y, l;
//        int cnt = 0;
//        Console.WriteLine("Введите радиус");
//        r = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите абсциссу центра КРУГА");
//        a = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите ординату центра КРУГА");
//        b = double.Parse(Console.ReadLine());
//        Console.WriteLine("Введите количество точек");
//        n = int.Parse(Console.ReadLine());
//        for (int i = 1; i<=n; i++)
//        {
//            Console.WriteLine("Введите абсциссу точки");
//            x = double.Parse(Console.ReadLine());
//            Console.WriteLine("Введите ординату точки");
//            y = double.Parse(Console.ReadLine());
//            l = Math.Sqrt((a - x) * (a - x) + (b - y) * (b - y));
//            if (l<=r)
//            {
//                cnt++;
//            }
//        }
//        Console.WriteLine(cnt);
//    }
//}

// задание №5
//using System;
//class Programm
//{
//    static void Main(string[] agrs)
//    {
//        int n = 30;
//        double t, rez;
//        int cnt = 0; //сколько человек сдали норматив 
//        Console.WriteLine("Введите норматив");
//        t = double.Parse(Console.ReadLine());
//        for (int i = 1; i <= n; i++)
//        {
//            Console.WriteLine("Введите результаты спортсмена");
//            rez = double.Parse(Console.ReadLine());
//            if(rez<=t)
//            {
//                cnt++;
//            }
//        }
//        Console.WriteLine(cnt);

//    }
//}

// задание номер №8
using System;
class Programm
{
    static void Main(string[] agrs)
    {
        int n;
        double x, y, l;
        double min = 99999;
        int index = 0;
        Console.WriteLine("Введите количество точек");
        n = int.Parse(Console.ReadLine());
        for(int i=1; i<=n; i++)
        {
            Console.WriteLine("Введите абсциссу точки");
            x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите ординату точки");
            y = double.Parse(Console.ReadLine());
            l = x*x+y*y;
            if(l<min)
            {
                min = l;
                index = i;
            }
        }
        Console.WriteLine(index);
    }
}