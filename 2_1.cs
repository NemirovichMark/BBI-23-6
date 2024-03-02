using System;
class Program
{
    private static void Main(string[] args)
    {
        //Заполнение массива людей
        Student[] Students = new Student[]
        {
                new Student("Шолохов А.В", new double[] {2, 2, 4, 5}),
                new Student("Горохов М.И", new double[] {4, 4, 3, 5}),
                new Student("Котова В.И", new double[] {5, 4, 5, 5}),
                new Student("Дегтярев З.В", new double[] {3, 4, 5, 5}),
                new Student("Тихонов Д.Е", new double[] {4, 2, 3, 4}),
        };

        //Сортировка по среднему баллу
        BubbleSort(Students);
        Console.WriteLine($"ФИО - Средний Балл");
        for (int i = Students.Length - 1; i >= 0; i--)
        {
            if (Students[i].GetMiddleMark() >= 4)
            {
                Students[i].Print();
            }
        }
        Console.ReadKey();
    }

    static void Swap(ref Student e1, ref Student e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }

    //сортировка пузырьком
    static void BubbleSort(Student[] array)
    {
        var len = array.Length;
        for (var i = 1; i < len; i++)
        {
            for (var j = 0; j < len - i; j++)
            {
                if (array[j].GetMiddleMark() > array[j + 1].GetMiddleMark())
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    struct Student
    {
        public string FIO { get; private set; }

        private double[] Marks;
        public Student(string fio, double[] marks)
        {
            FIO = fio;
            Marks = marks;
        }

        public double GetMiddleMark()
        {
            double sum = 0;
            for (int i = 0; i < Marks.Length; i++)
            {
                sum += Marks[i];
            }

            return sum / Marks.Length;
        }

        public void Print()
        {
            Console.WriteLine($"{FIO} - {GetMiddleMark()}");
        }
    }
}