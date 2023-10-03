using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //2
            //double sum = 0;
            //for (double i = 1; i <= 10; i += 1)
            //    sum = sum + (1 / i);
            //Console.WriteLine(sum);

            //3
            //double sum = 0;
            //for (double i = 1; i <= 113; i += 2)
            //{
            //    sum += (i + 1) / (i + 2);
            //}
            //Console.WriteLine(sum);

            //4
            //double sum = 0;
            //int x = 10;
            //for (int i = 0; i <= 8; i += 1)
            //{
            //    sum += Math.Cos((i + 1) * x) / Math.Pow(x, 0);
            //}
            //Console.WriteLine(sum);

            //5
            //int p = 1;
            //int sum = 0;
            //for (int h = 0; h <= 9; h++)
            //{
            //    int ph = p + h;
            //    sum = (int)(sum + Math.Pow(ph, 2));
            //}
            //Console.WriteLine(sum);

            //6
            //double number = 0;
            //for (double i = -4; i <= 4; i += 0.5)
            //{
            //    number = (Math.Pow(0.5 * i, 2) - 7 * i);
            //    Console.WriteLine($"{number} {i}");

            //7
            //int proizv = 1;
            //for (int i = 1; i <= 6; i++)
            //{
            //    proizv = proizv * i;
            //}
            //Console.WriteLine(proizv);

            //8
            //int sum = 0;
            //int fact1 = 1;
            //for (int i = 1; i <= 6; i++)
            //{
            //    fact1 = fact1 * i;
            //    sum += fact1;
            //}
            //Console.WriteLine(sum);

            //9
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

            //10
            //int number = 1;
            //for (int i = 1; i <= 7; i++)
            //{
            //    number *= 3;
            //}
            //Console.WriteLine(number);

            //11
            //int j = 6;
            //for (int i = 1; i < j; i++)
            //{
            //    Console.Write(i + " ");
            //}
            //Console.Write($"{j},");
            //Console.WriteLine();
            //int b = 5;
            //for (int i = 0; i < b; i++)
            //{
            //    Console.Write(b + " ");
            //}
            //Console.Write($"{b}.");
            //Console.WriteLine();

            //12
            //double sum = 0;
            //int x = 2;
            //for (int i = 0; i <= 10; i++)
            //{
            //    sum += 1 / Math.Pow(x, i);
            //}
            //Console.WriteLine(sum);

            //2 уровень
            //1
            //double sum = 0;
            //int x = 1;
            //int n = Convert.ToInt32(Console.ReadLine());
            //for (int i = 1; i <= n; i++)
            //{
            //    sum += Math.Cos(i * x) / Math.Pow(i, 2);
            //    if (Math.Abs(Math.Cos(i * x) / Math.Pow(i, 2)) < 0.0001)
            //    {
            //        Console.WriteLine(sum);
            //        break;

            //2
            //int sum = 1;
            //int last_sum = 0;

            //for (int i = 1; i <= 10000; i += 3)
            //{
            //    sum *= i;
            //    if (sum <= 30000)
            //    {
            //        last_sum = sum;
            //    }
            //    if (sum > 30000)
            //    {
            //        Console.WriteLine(last_sum);
            //        break;
            //    }
            //}

            //3
            //class Program
            //{
            //static void Main()
            //{
            //    int s = 0, n = 0, m;
            //    const int a = 2, h = 3, p = 41;
            //    while (s <= p)
            //    {
            //        m = a + n * h;
            //        s = s + m;
            //        n = n + 1;
            //    }
            //    n--;
            //    Console.WriteLine($"{n:d}");
            //}
            //}

            //4
            //            using System;
            //class Program
            //        {
            //            static void Main()
            //            {
            //                double sum = 0;
            //                double x = 0.9;
            //                double last_sum = 0;
            //                for (int n = 1; n <= 10000; n++)
            //                {
            //                    sum += Math.Pow(x, n * 2);
            //                    if (Math.Pow(x, n * 2) >= 0.0001)
            //                    {
            //                        last_sum = sum;
            //                    }

            //                    if (Math.Pow(x, n * 2) < 0.0001)
            //                    {
            //                        Console.WriteLine(last_sum);
            //                        break;
            //                    }
            //                }

            //            }
            //        }

            //5
            //double res = 0;
            //int n = Convert.ToInt32(Console.ReadLine());
            //int m = Convert.ToInt32(Console.ReadLine());

            //while (n >= m)
            //{
            //    res += 1;
            //    n -= m;
            //}
            //Console.WriteLine($"частное: {res}");
            //if (n < m)
            //{
            //    if (n > 0)
            //    {
            //        Console.WriteLine($"остаток:{n}");
            //    }
            //    if (n == 0)
            //    {
            //        Console.WriteLine("остаток: 0");
            //    }
            //}

            //6
//            using System;

//class Program
//        {
//            static void Main(string[] args)
//            {
//                int n = 1; // Начальное количество клеток
//                int time = 0; // Время

//                while (n != 105) // Пока количество клеток не достигнет 105
//                {
//                    time++; // Увеличиваем время на 1

//                    // Увеличиваем количество клеток на значение, равное текущему количеству клеток
//                    n += n;

//                    // Если количество клеток становится больше 105, то присваиваем значение 105
//                    if (n > 105)
//                    {
//                        n = 105;
//                    }
//                }

//                Console.WriteLine("Время: " + time);
//                Console.ReadKey();
//            }
//        }
            //7
            //double r = 10;
            //double sum = 10;
            //for (int kolvo = 1; kolvo < 7; kolvo++)
            //{
            //    r = r + r * 0.1;
            //    sum += r;
            //}
            //Console.WriteLine(sum);
            // ответ: 94,87171 

// lv 2 num 7.2

//double r = 10;
//double sum = 10;
//int kolvo = 1;
//for (kolvo = 1; sum < 100;)
//{
//    r = r + r * 0.1;
//    sum += r;
//    kolvo += 1;
//}
//Console.WriteLine(kolvo);
//// ответ: 8

//// lv 2 num 7.3

//double r = 10;
//double sum = 10;
//int kolvo = 1;
//for (kolvo = 1; r <= 20;)
//{
//    r = r + r * 0.1;
//    kolvo += 1;
//}
//Console.WriteLine(kolvo);
//// ответ: 9

//// lv 2 num 8

//double vklad = 10000;
//int month = 0;
//for (month = 0; vklad < 20000;)
//{
//    vklad = vklad * 1.08;
//    month++;
//}
//Console.WriteLine(month);

//8
//{
//    static void Main()
//    {
//        double sum = 10000;
//        for (int i = 1; i <= 100; i++)
//        {
//            sum *= 1.08;
//            if (sum >= 20000)
//            {
//                Console.WriteLine(i);
//                break;
//            }
//        }
//    }
//}

//3 уровень
//5
//            using System;
//class Program
//        {
//            static void Main()
//            {
//                double a = Math.PI / 5;
//                double b = Math.PI;
//                double h = Math.PI / 25;
//                double sum = 0;
//                double y = 0;
//                double last_number = 0;
//                for (int i = 1; i < 10000; i++)
//                {
//                    for (double x = a; x <= b; x += h)
//                    {
//                        sum += Math.Pow(-1, i) * Math.Cos(i * x) / Math.Pow(i, 2);
//                        y = (Math.Pow(x, 2) - Math.Pow(Math.PI, 2) / 2) / 4;
//                        Console.WriteLine($"{sum} {y}");
//                        last_number = Math.Pow(-1, i) * Math.Cos(i * x) / Math.Pow(i, 2);
//                    }
//                    if (Math.Abs(last_number) < 0.0001)
//                    {
//                        break;
//                    }
//                }
//            }
//        }


