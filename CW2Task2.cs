using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1;



internal class CW2Task2
{

    abstract class Vehicle
    {
        private const int nowYear = 2024;
        private static int number = 1;
        private string marka;
        private string model;
        private int year;
        private int distance;
        private int vim = number++;
        private string info;

        public Vehicle(string marka, string model, int year, int distance)
        {
            this.marka = marka;
            this.model = model;
            this.year = year;
            this.distance = distance;
            Characteristic();
        }

        public string Marka => marka;
        public string Model => model;
        public string Info => info;
        public int Year => year;
        public int Distance => distance;
        public int Vim => vim;

        public override string ToString()
        {
            return $"{marka,-15}{model,-15}{year,-15}{distance,-15}{vim,-10}{info, -15}";
        }

        private void Characteristic()
        {
            int a = nowYear - year;
            double probeg = (double)distance / a;
            if (probeg < 100)
            {
                info = "простаивающая";
            }
            else if (probeg < 500)
            {
                info = "праздничная";
            }
            else
            {
                info = "рабочая";
            }
        }

        private static int Maxik(Vehicle[] cars, int l, int r)
        {
            int indexMaxi = l;
            for (int i = l + 1; i < r; i++)
            {
                if (cars[indexMaxi].Year < cars[i].Year)
                {
                    indexMaxi = i;
                }
            }
            return indexMaxi;
        }

        private static void Swapchik(Vehicle[] cars, int indexA, int indexB)
        {
            Vehicle t = cars[indexA];
            cars[indexA] = cars[indexB];
            cars[indexB] = t;
        }

        public static void Sortic(Vehicle[] cars)
        {
            int n = cars.Length;
            for (int i = 0; i < n; ++i)
            {
                Swapchik(cars, Maxik(cars, i, n), i);
            }
        }
    }

    class Car : Vehicle {
        private string classCar;

        public Car(string marka, string model, int year, int distance, string classCar) : base(marka, model, year, distance)
        {
            this.classCar = classCar;
        }

        public string ClassCar => classCar;

        public override string ToString()
        {
            return base.ToString() + $"{classCar,-10}";
        }
    }

    class Truck : Vehicle
    {
        private int numberWheels;
        public Truck(string marka, string model, int year, int distance, int numberWheels) : base(marka, model, year, distance)
        {
            this.numberWheels = numberWheels;
        }

        public int NymberWheels => numberWheels;

        public override string ToString()
        {
            return base.ToString() + $"{numberWheels,-10}";
        }
    }

    class Motorcycle : Vehicle
    {
        public Motorcycle(string marka, string model, int year, int distance) : base(marka, model, year, distance)
        {
        }
    }

    public static void Main(string[] args)
    {
        Car[] cars = new Car[5]
        {
            new Car("Господи", "Какая", 2020, 5000, "S"),
            new Car("же", "блин", 2019, 10000, "S"),
            new Car("сложная", "задача", 2018, 3000, "B"),
            new Car("я", "очень", 2017, 800, "C"),
            new Car("долго", "пишу", 2016, 10000000, "A")
        };

        Truck[] trucks = new Truck[5]
        {
            new Truck("А", "Я", 2020, 50030, 4),
            new Truck("Иду", "такая", 2000, 103000, 4),
            new Truck("вся", "Дольче", 1900, 30030, 8),
            new Truck("Габбана", "Слёзы", 2005, 8030, 10),
            new Truck("душат", "душат", 2007, 103000000, 11)
        };

        Motorcycle[] motorcycles = new Motorcycle[5]
        {
            new Motorcycle("После", "Таких", 2023, 1),
            new Motorcycle("задач", "не", 2009, 9999),
            new Motorcycle("хочется", "даже", 2008, 888888),
            new Motorcycle("прогать", "я", 1999, 77777),
            new Motorcycle("в", "шоке", 2001, 123456789)
        };

        Vehicle.Sortic(cars);
        for (int i = 0; i < cars.Length; ++i)
        {
            Console.WriteLine(cars[i].ToString());
        }
        Vehicle.Sortic(trucks);
        Console.WriteLine();
        for (int i = 0; i < trucks.Length; ++i)
        {
            Console.WriteLine(trucks[i].ToString());
        }
        Vehicle.Sortic(motorcycles);
        Console.WriteLine();
        for (int i = 0; i < motorcycles.Length; ++i)
        {
            Console.WriteLine(motorcycles[i].ToString());
        }
        Console.WriteLine();
        Vehicle[] vehicles = new Vehicle[15];
        for(int i = 0; i < vehicles.Length; ++i)
        {
            if (i < 5)
            {
                vehicles[i] = cars[i];
            }else if (i < 10)
            {
                vehicles[i] = trucks[i % 5];
            }
            else
            {
                vehicles[i] = motorcycles[i % 5];
            }
        }
        Vehicle.Sortic(vehicles);
        for (int i = 0; i < vehicles.Length; ++i)
        {
            Console.WriteLine(vehicles[i].ToString());
        }
    }
}
