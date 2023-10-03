
//1.13
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        double h = 0.1;
//        double min = -1.5;
//        double max = 1.5;
//        Console.WriteLine("x | y");
//        Console.WriteLine("___________");
//        double x = min;
//        while (x <= max)
//        {
//            string sx = string.Format("{0:f1}", x);
//            if (x >= 0)
//            {
//                Console.Write("");
//            }
//            Console.Write(sx);
//            if (x <= -1)
//            {
//                Console.WriteLine($" | 1");
//            }
//            else if (x > -1 && x <= 1)
//            {
//                string sy = string.Format("{0:f1}", -x);
//                Console.Write("|");
//                Console.WriteLine(sy);
//            }
//            else
//            {
//                Console.WriteLine($"|-1");
//            }
//            x = x + h;
//        }
//    }
//}


//1.4
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        double s = 0;
//        double x = 12;
//        double d = 1;
//        for (double i = 1; i <= 9; i++)
//        {
//            s = s + (Math.Cos(i * x) / d);
//            d = d * x;
//        }
//        Console.WriteLine(s);
//    }
//}


//1.12
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        double s = 0;
//        double x = Convert.ToDouble(Console.WriteLine());
//        double a = x;
//        for (int i = 0; i <= 10; i++)
//        {
//            a = a / x;
//            s = s + x;
//        }
//        Console.WriteLine(s);
//    }
//}


//1.9
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        double s = 0;
//        double a = 0;
//        for (int i = 1; i <= 6; i++)
//        {
//            a = (-1) * a * 5 / i;
//            s = s + a;
//        }
//        Console.WriteLine(s);
//    }
//}

//1.3
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        double s = 0;
//        for (double a = 2; a <= 112; a++)
//        {
//            s = s + (a / (a + 1));
//        }
//        Console.WriteLine(s);
//    }
//}

//1.15
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int a = 1;
//        int b = 2;
//        int c = a + b;
//        int x = 1;
//        int y = 1;
//        int z = x + y;
//        for (int i = 1; i <= 2; i++)
//        {
//            a = b;
//            b = c;
//            c = a + b;
//            x = y;
//            y = z;
//            z = x + y;
//        }
//        Console.WriteLine((1.0 * c / z));
//    }
//}


//1.14
//using System;
//internal class Program
//{
//    static void Main(string[] args)
//    {
//        int a = 1;
//        int b = 1;
//        int c = a + b;
//        Console.Write("1 1");
//        for (int i = 1; i <= 7; i++)
//        {
//            a = b;
//            b = c;
//            c = a + b;
//            Console.Write($" {c}");
//        }
//    }
//}


       

       





    


  

