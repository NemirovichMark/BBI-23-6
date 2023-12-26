using System;

namespace ConsoleApp1
{
    internal class Program1
    {
            // 1.
            // double r = 2;
            
            //         // Точки:
            //         double x1 = 0, y1 = 2;
            //         double x2 = 1.5, y2 = 0.7;
            //         double x3 = 1, y3 = 1;
            //         double x4 = 3, y4 = 0;
            
            //         Console.WriteLine("Задание 1:");
            
            //         Console.WriteLine("Точка ({0}, {1}) лежит на окружности: {2}", x1, y1, IsPointOnCircle(x1, y1, r));
            //         Console.WriteLine("Точка ({0}, {1}) лежит на окружности: {2}", x2, y2, IsPointOnCircle(x2, y2, r));
            //         Console.WriteLine("Точка ({0}, {1}) лежит на окружности: {2}", x3, y3, IsPointOnCircle(x3, y3, r));
            //         Console.WriteLine("Точка ({0}, {1}) лежит на окружности: {2}", x4, y4, IsPointOnCircle(x4, y4, r));
            
            
            // 4.
            // double a = 5, b = 3, c = 7;
            
            //         double z = Math.Max(Math.Min(a, b), c);
            
            //         Console.WriteLine("\nЗадание 4:");
            //         Console.WriteLine("Z = {0}", z);


            //     7.
            //      double x = 2;
            //             double y;
                
            //             if (Math.Abs(x) > 1)
            //                 y = 1;
//                         else
//                             y = Math.Abs(x);
                
//                         Console.WriteLine("Y = {0}", y);
                
//                 1.
//                         Console.WriteLine("Введите количество учеников в классе:");
//                         int n = int.Parse(Console.ReadLine());
                
//                         int[] heights = new int[n];
//                         string[] genders = new string[n];
                
//                         for (int i = 0; i < n; i++)
//                         {
//                             Console.WriteLine($"Введите рост ученика #{i+1}:");
//                             heights[i] = int.Parse(Console.ReadLine());
                
//                             Console.WriteLine($"Введите пол ученика #{i+1} (м или ж):");
//                             genders[i] = Console.ReadLine();
//                         }

//                 int sumHeightBoys = 0, countBoys = 0;
//                         int sumHeightGirls = 0, countGirls = 0;
                
//                         for (int i = 0; i < n; i++)
//                         {
//                             if (genders[i] == "м")
//                             {
//                                 sumHeightBoys += heights[i];
//                                 countBoys++;
//                             }
//                             else if (genders[i] == "ж")
//                             {
//                                 sumHeightGirls += heights[i];
//                                 countGirls++;
//                             }
//                         }
                
//                         double averageHeightBoys = (double)sumHeightBoys / countBoys;
//                         double averageHeightGirls = (double)sumHeightGirls / countGirls;
                
//                         Console.WriteLine($"Средний рост мальчиков: {averageHeightBoys}");
//                         Console.WriteLine($"Средний рост девочек: {averageHeightGirls}");
                
//                 4. 
//                 Console.WriteLine("Введите внутренний радиус кольца:");
//                         double r1 = double.Parse(Console.ReadLine());
                
//                         Console.WriteLine("Введите внешний радиус кольца:");
//                         double r2 = double.Parse(Console.ReadLine());
                
//                         Console.WriteLine("Введите количество точек:");
//                         int n = int.Parse(Console.ReadLine());
                
//                         int pointsInRing = 0;

//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine($"Введите координаты точки #{i+1}:");
//             Console.WriteLine("x:");
//             double x = double.Parse(Console.ReadLine());

//             Console.WriteLine("y:");
//             double y = double.Parse(Console.ReadLine());

//             double distance = Math.Sqrt(x * x + y * y);

//             if (distance >= r1 && distance <= r2)
//             {
//                 pointsInRing++;
//             }
//         }

//         Console.WriteLine($"Количество точек, попадающих в кольцо: {pointsInRing}");

// 7.
//         Console.WriteLine("Введите количество точек:");
//         int n = int.Parse(Console.ReadLine());

//         int[] xCoordinates = new int[n];
//         int[] yCoordinates = new int[n];

//         int countPointsQ1 = 0, countPointsQ3 = 0;

//         for (int i = 0; i < n; i++)
//         {
//             Console.WriteLine($"Введите координаты точки #{i+1}:");
//             Console.WriteLine("x:");
//             xCoordinates[i] = int.Parse(Console.ReadLine());

//             Console.WriteLine("y:");
//             yCoordinates[i] = int.Parse(Console.ReadLine());

//             if (xCoordinates[i] > 0 && yCoordinates[i] > 0)
//             {
//                 Console.WriteLine($"Точка #{i+1} находится в 1-м квадранте");
//                 countPointsQ1++;
//             }
//             else if (xCoordinates[i] < 0 && yCoordinates[i] < 0)
//             {
//                 Console.WriteLine($"Точка #{i+1} находится в 3-м квадранте");
//                 countPointsQ3++;
//             }
//         }

//         Console.WriteLine($"Количество точек в 1-м квадранте: {countPointsQ1}");
//         Console.WriteLine($"Количество точек в 3-м квадранте: {countPointsQ3}"
    }
}
