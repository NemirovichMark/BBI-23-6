using System;
class Program
{
    private static void Main(string[] args)
    {
        //Заполнение массива людей первой группы
        Student[] Students1 = new Student[]
        {
                new Student("Шолохов А.В", new double[] {2, 2, 4, 5}),
                new Student("Горохов М.И", new double[] {4, 4, 3, 5}),
                new Student("Котова В.И", new double[] {5, 4, 5, 5}),
                new Student("Дегтярев З.В", new double[] {3, 4, 5, 5}),
                new Student("Тихонов Д.Е", new double[] {4, 2, 3, 4}),
        };

        //Заполнение массива людей первой группы
        Student[] Students2 = new Student[]
        {
                new Student("Долгий М.С", new double[] {2, 3, 4, 5}),
                new Student("Голубев С.И", new double[] {3, 3, 2, 5}),
                new Student("Дулов И.И", new double[] {4, 4, 5, 5}),
                new Student("Павлов Ч.В", new double[] {4, 4, 5, 5}),
                new Student("Грачев Т.И", new double[] {5, 5, 3, 4}),
        };

        //Заполнение массива людей первой группы
        Student[] Students3 = new Student[]
        {
                new Student("Печерин С.С", new double[] {4, 4, 3, 5}),
                new Student("Иванов Т.С", new double[] {4, 3, 2, 5}),
                new Student("Тетюлин С.В", new double[] {5, 2, 5, 5}),
                new Student("Дятлов У.Е", new double[] {5, 2, 4, 5}),
                new Student("Воробев С.И", new double[] {5, 3, 4, 4}),
        };

        StudentGroup[] flow = new StudentGroup[]
        {
                new StudentGroup(Students1, 1),
                new StudentGroup(Students2, 2),
                new StudentGroup(Students3, 3),
        };

        //Сортировка по среднему баллу
        Console.WriteLine($"Группа - Средний Балл Группы");
        for (int i = BubbleSort(flow).Length - 1; i >= 0; i--)
        {
            Console.WriteLine($"{flow[i].GroupNumber} - {flow[i].GetMiddleMarkGroup()}");
        }
    }

    static void Swap(ref StudentGroup e1, ref StudentGroup e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }

    //сортировка пузырьком
    static StudentGroup[] BubbleSort(StudentGroup[] array)
    {
        var len = array.Length;
        for (var i = 1; i < len; i++)
        {
            for (var j = 0; j < len - i; j++)
            {
                if (array[j].GetMiddleMarkGroup() > array[j + 1].GetMiddleMarkGroup())
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }

        return array;
    }

    class Student
    {
        public string FIO { get; private set; }

        private double[] Marks = new double[5];
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
    }

    class StudentGroup
    {
        public Student[] Students;

        public int GroupNumber;

        public StudentGroup(Student[] students, int groupNumber)
        {
            Students = students;
            GroupNumber = groupNumber;
        }

        public double GetMiddleMarkGroup()
        {
            double sum = 0;
            for (int i = 0; i < Students.Length; i++)
            {
                sum += Students[i].GetMiddleMark();
            }

            return sum / Students.Length;
        }
    }
}