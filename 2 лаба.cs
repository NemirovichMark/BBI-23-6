
namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region//1 уровень 3 задача
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c;

            if (a > 0)
            {
                if (a > b)
                {
                    c = a;
                }
                else
                {
                    c = b;
                }
            }
            else if (a < b)
                c = a;
            else c = b;
            Console.WriteLine("c=" + c);
            Console.WriteLine("Конец 3 задачи");
            #endregion

            #region//1 уровень 6а задача
            double r = 3.2, s = 3.5,rad,storona;
            rad = Math.Sqrt(r / 3.14);
            storona = Math.Sqrt(s);
            if (2 * Math.Abs(rad) < Math.Abs(storona))
                Console.WriteLine("Поместится");
            else Console.WriteLine("Не поместится");
            Console.WriteLine("Конец 6а задачи");
            #endregion

            #region//1 уровень 6б задача
            double r2 = 3.2, s2 = 4, rad2, storona2;
            rad2 = Math.Sqrt(r2 / 3.14);
            storona2 = Math.Sqrt(s2);
            if (2 * Math.Abs(rad2) < Math.Abs(storona2))
                Console.WriteLine("Поместится");
            else Console.WriteLine("Не поместится");
            Console.WriteLine("Конец 6б задачи");
            #endregion

            #region//1 уровень 6г задача
            double r3 = 6, s3 = 9, rad3,storona3;
            rad3 = Math.Sqrt(r3 / 3.14);
            storona3 = Math.Sqrt(s3);
            if (2 * Math.Abs(rad3) < Math.Abs(storona3))
                Console.WriteLine("Поместится");
            else Console.WriteLine("Не поместится");
            Console.WriteLine("Конец 6г задачи");
            #endregion

           #region//1 уровень 9 задача
            double y;
            double x = Convert.ToDouble(Console.ReadLine());
            if (x <= -1)
                y = 0;
            else if (x > -1 && x <= 0)
                y = 1 + x;
            else y = 1;
            Console.WriteLine(y);
            Console.WriteLine("Конец 9 задачи");
            #endregion

            #region//2 уровень 3 задача
            int m =200,sum=0;//мл молока, сумма мл молока
            int n = 5;// количество учеников
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Введите вес ученика");
                double ves = Convert.ToDouble(Console.ReadLine());// вводится вес ученика
                if (ves < 30)
                {
                    sum = sum + m;
                }
                else if (ves ==0) break;
            }
            Console.WriteLine("На {0:f0} первоклассников требуется {1:f0} мл молока",n,sum);
            Console.WriteLine("Конец 3 задачи");
            #endregion

            #region//2 уровень 6 задача
            int n; // количество точек
            int count = 0; // количество точек, принадлежащих фигуре

            Console.Write("Введите количество точек: ");
            n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                double x, y; // координаты точки

                Console.Write($"Введите координаты {i + 1}-ой точки (через пробел): ");
                x = Convert.ToDouble(Console.ReadLine());
                y = Convert.ToDouble(Console.ReadLine());

                if (y >= 0 && y <= Math.Sin(x)) // проверка принадлежности фигуре
                {
                    count++;
                }
            }

            Console.WriteLine($"Из {n} точек {count} принадлежат фигуре.");
            #endregion

            #region//2 уровень 9 задача
            int n3 = Convert.ToInt16(Console.ReadLine());
            double mintime = 1000000;
            for (int i = 1; i <= n3; i++)
            {
                double time = Convert.ToDouble(Console.ReadLine());
                if (time < mintime)
                {
                    mintime = time;
                }

            }
            Console.WriteLine(mintime);
            Console.WriteLine("Конец 9 задачи");
            #endregion


        }
    }
}
