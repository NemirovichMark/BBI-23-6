namespace ConsoleApp1;

class CW1Task1
{
    struct Car
    {
        private const int nowYear = 2024;
        private static int number = 1;
        private string marka;
        private string model;
        private int year;
        private int distance;
        private int vim = number++;
        private string info;

        public Car(string marka, string model, int year, int distance)
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
            return $"{marka, -10}{model, -10}{year, -10}{distance, -10}{vim, -10}{info}";
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

        private static int Maxik(Car[] cars, int l, int r)
        {
            int indexMaxi = l;
            for(int i = l + 1; i < r; i++)
            {
                if (cars[indexMaxi].Distance < cars[i].Distance)
                {
                    indexMaxi = i;
                }
            }
            return indexMaxi;
        }

        private static void Swapchik(Car[] cars, int indexA, int indexB) {
            Car t = cars[indexA];
            cars[indexA] = cars[indexB];
            cars[indexB] = t;
        }

        public static void Sortic(Car[] cars)
        {
            int n = cars.Length;
            for(int i = 0; i < n; ++i)
            {
                Swapchik(cars, Maxik(cars, i, n), i);
            }
        }
    }
    public static void Main(string[] args)
    {
        Car[] cars = new Car[5]
        {
            new Car("Господи", "Какая", 2020, 5000),
            new Car("же", "блин", 2019, 10000),
            new Car("сложная", "задача", 2018, 3000),
            new Car("я", "очень", 2017, 800),
            new Car("долго", "пишу", 2016, 10000000) 
        };
        Car.Sortic(cars);
        for(int i = 0; i < cars.Length; ++i)
        {
            Console.WriteLine(cars[i].ToString());
        }
    }
}