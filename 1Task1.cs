using System;

struct Point
{
    public double X { get; }
    public double Y { get; }

    public Point(double[] coordinates)
    {
        X = coordinates[0];
        Y = coordinates[1];
    }

    public static double Distance(Point point1, Point point2)
    {
        double deltaX = point2.X - point1.X;
        double deltaY = point2.Y - point1.Y;
        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    }

    public static void PrintDistance(Point point1, Point point2)
    {
        Console.WriteLine("X1:" + " " + point1.X + " " + "Y1:" + " " + point1.Y);
        Console.WriteLine("X2:" + " " + point2.X + " " + "Y2:" + " " + point2.Y);
        Console.WriteLine("Расстояние между ними:" + Distance(point1, point2));
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Point[] points = new Point[3];
        points[0] = new Point(new double[] { 0, 0 });
        points[1] = new Point(new double[] { 3, 4 });
        points[2] = new Point(new double[] { -2, 6 });

        for (int i = 0; i < points.Length - 1; i++)
        {
            for (int j = i + 1; j < points.Length; j++)
            {
                Point.PrintDistance(points[i], points[j]);
            }
        }
    }
}
