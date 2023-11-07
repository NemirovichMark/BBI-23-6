internal class Program
{
    static void Main(string[] args)
    {
        //1.3

        int a = Int32.Parse(Console.ReadLine());
        int b = Int32.Parse(Console.ReadLine());
        int c;
        if (a > 0)
        {
            c = Math.Max(a, b);
        }
        else
        {
            c = Math.Min(a, b);
        }
        Console.WriteLine($"c = {c}");




        //1.6(1)
        double r = 3.2;
        double s = 3.5;

        double circleArea = Math.PI * Math.Pow(r, 2);
        double squareArea = Math.Pow(s, 2);

        if (circleArea <= squareArea)
        {
            Console.WriteLine("Круг помещается в квадрате");
        }
        else
        {
            Console.WriteLine("Круг не помещается в квадрате");
        }

        //  1.6(2)
        double r2 = 3.2;
        double s2 = 4;

        double circleArea2 = Math.PI * Math.Pow(r, 2);
        double squareArea2 = Math.Pow(s, 2);

        if (circleArea <= squareArea)
        {
            Console.WriteLine("Круг помещается в квадрате");
        }
        else
        {
            Console.WriteLine("Круг не помещается в квадрате");
        }

        // 1.6(3)
        double r163= 6;
        double s3 = 9;

        double circleArea3 = Math.PI * Math.Pow(r163, 2);
        double squareArea3 = Math.Pow(s3,2);

        if (circleArea <= squareArea)
        {
            Console.WriteLine("Круг помещается в квадрате");
        }
        else
        {
            Console.WriteLine("Круг не помещается в квадрате");
        }

        // 1.9
        Console.Write("Введите значение аргумента x: ");
        double x = double.Parse(Console.ReadLine());

        double y;

        if (x <= -1)
        {
            y = 0;
        }
        else if (x <= 0)
        {
            y = 1 + x;
        }
        else
        {
            y = 1;
        }

        Console.WriteLine("Значение функции y = " + y);

        // 2.3.
        int n;
        double weight; 

        Console.Write("введите количество учеников в классе: ");
        n = Convert.ToInt32(Console.ReadLine());

        double totalMilk = 0;
        for (int i = 1; i <= n; i++)
        {
            Console.Write($"введите вес {i}-го ученика (кг): ");
            weight = Convert.ToDouble(Console.ReadLine());

            if (weight < 30)
            {
                
                totalMilk += 0.2; 
            }
        }

        Console.WriteLine($"каждый день для одного класса из {n} учеников нужно {totalMilk} литров молока.");
        Console.ReadLine();

        // 2.6
        Console.WriteLine("Введите количество точек:");
        int n26 = int.Parse(Console.ReadLine());

        int count = 0;

        for (int i = 0; i < n26; i++)
        {
            Console.WriteLine($"Введите координаты точки {i + 1}:");
            double x26 = double.Parse(Console.ReadLine());
            double y26 = double.Parse(Console.ReadLine());

            if (x26 >= 0 && x26 <= Math.PI && y26 >= 0 && y26 <= Math.Sin(x))
            {
                count++;
            }
        }

        Console.WriteLine($"Количество точек, принадлежащих фигуре: {count}");


        // 2.9
        int n29 = Int32.Parse(Console.ReadLine());
        int best = 0;

        for (int i = 0; i < n29; i++)
        {
            int dist = Int32.Parse(Console.ReadLine());
            best = Math.Max(best, dist);
        }

        Console.WriteLine($"Лучший результат: {best}");
    }
}
        
