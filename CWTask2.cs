using System;
using System.Linq;

abstract class Shape
{
    protected double _volume;
    public double Volume => _volume;
    public abstract void CalculateVolume();
    public abstract void PrintInfo();
}

class Sphere : Shape
{
    protected double _radius;

    public Sphere(double radius)
    {
        _radius = radius;
        CalculateVolume();
    }

    public override void CalculateVolume()
    {
        _volume = (4.0 / 3.0) * Math.PI * Math.Pow(_radius, 3);
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Сфера с радиусом {_radius}, объем: {_volume}");
    }
}

class Cube : Shape
{
    protected double _sideLength;

    public Cube(double sideLength)
    {
        _sideLength = sideLength;
        CalculateVolume();
    }

    public override void CalculateVolume()
    {
        _volume = Math.Pow(_sideLength, 3);
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Кубы с длиной стороны {_sideLength}, объем: {_volume}");
    }
}

class Cylinder : Shape
{
    protected double _radius;
    protected double _height;

    public Cylinder(double radius, double height)
    {
        _radius = radius;
        _height = height;
        CalculateVolume();
    }

    public override void CalculateVolume()
    {
        _volume = Math.PI * Math.Pow(_radius, 2) * _height;
    }

    public override void PrintInfo()
    {
        Console.WriteLine($"Цилиндр с радиусом {_radius} и высотой {_height}, объем: {_volume}");
    }
}

class Program
{
    static void Main()
    {
        Shape[] spheres = new Shape[]
        {
            new Sphere(5),
            new Sphere(3),
            new Sphere(7),
            new Sphere(2),
            new Sphere(4)
        };

        Shape[] cubes = new Shape[]
        {
            new Cube(4),
            new Cube(2),
            new Cube(6),
            new Cube(3),
            new Cube(5)
        };

        Shape[] cylinders = new Shape[]
        {
            new Cylinder(2, 5),
            new Cylinder(3, 7),
            new Cylinder(1, 4),
            new Cylinder(4, 6),
            new Cylinder(5, 8)
        };

        Sorting(spheres);
        Sorting(cubes);
        Sorting(cylinders);

        Console.WriteLine("Сферы:");
        PrintShapes(spheres);

        Console.WriteLine("Кубы:");
        PrintShapes(cubes);

        Console.WriteLine("Цилиндры:");
        PrintShapes(cylinders);

        int totalShapes = spheres.Length + cubes.Length + cylinders.Length;
        Shape[] allShapes = new Shape[totalShapes];

        int index = 0;
        foreach (var shape in spheres)
        {
            allShapes[index] = shape;
            index++;
        }
        foreach (var shape in cubes)
        {
            allShapes[index] = shape;
            index++;
        }
        foreach (var shape in cylinders)
        {
            allShapes[index] = shape;
            index++;
        }
        Sorting(allShapes);

        Console.WriteLine("Все фигуры (Descending):");
        PrintShapes(allShapes);
    }


    static void Sorting(Shape[] shapes)
    {
        int n = shapes.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (shapes[j].Volume < shapes[j + 1].Volume)
                {
                    Shape temp = shapes[j];
                    shapes[j] = shapes[j + 1];
                    shapes[j + 1] = temp;
                }
            }
        }
    }

    static void PrintShapes(Shape[] shapes)
    {
        foreach (var shape in shapes)
        {
            shape.PrintInfo();
        }
        Console.WriteLine();
    }
}
