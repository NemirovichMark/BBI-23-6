using System;

struct Vector
{
    public struct Dot
    {
        private int _x;
        private int _y;
        private int _z;

        public Dot(int x, int y, int z)
        {
            _x = x;
            _y = y;
            _z = z;
        }

        public int X => _x;
        public int Y => _y;
        public int Z => _z;
    }

    private Dot _point1;
    private Dot _point2;

    public Vector(Dot point1, Dot point2)
    {
        _point1 = point1;
        _point2 = point2;
    }

    public double Length()
    {
        int deltaX = _point2.X - _point1.X;
        int deltaY = _point2.Y - _point1.Y;
        int deltaZ = _point2.Z - _point1.Z;

        return Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    }

    public void PrintInfo()
    {
        Console.WriteLine($"Координаты первой точки: ({_point1.X}, {_point1.Y}, {_point1.Z})");
        Console.WriteLine($"Координаты второй точки: ({_point2.X}, {_point2.Y}, {_point2.Z})");
        Console.WriteLine($"Длина вектора: {Length()}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main()
    {
        Vector.Dot[] dotsArray = new Vector.Dot[]
        {
            new Vector.Dot(1, 2, 3),
            new Vector.Dot(4, 5, 6),
            new Vector.Dot(7, 8, 9),
            new Vector.Dot(10, 11, 12),
            new Vector.Dot(13, 14, 15)
        };

        Vector[] vectorsArray = new Vector[5];
        vectorsArray[0] = new Vector(dotsArray[0], dotsArray[1]);
        vectorsArray[1] = new Vector(dotsArray[1], dotsArray[2]);
        vectorsArray[2] = new Vector(dotsArray[2], dotsArray[3]);
        vectorsArray[3] = new Vector(dotsArray[3], dotsArray[4]);
        vectorsArray[4] = new Vector(dotsArray[4], dotsArray[0]);

        for (int i = 0; i < vectorsArray.Length - 1; i++)
        {
            for (int j = 0; j < vectorsArray.Length - 1 - i; j++)
            {
                if (vectorsArray[j].Length() < vectorsArray[j + 1].Length())
                {
                    Vector temp = vectorsArray[j];
                    vectorsArray[j] = vectorsArray[j + 1];
                    vectorsArray[j + 1] = temp;
                }
            }
        }

        foreach (var vector in vectorsArray)
        {
            vector.PrintInfo();
        }
    }
}
