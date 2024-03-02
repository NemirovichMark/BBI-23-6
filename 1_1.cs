using System;
class Program
{
    private static void Main(string[] args)
    {
        //Заполнение массива людей
        Jumper[] Jumpers = new Jumper[]
        {
                new Jumper("Шолохов", "ENF"),
                new Jumper("Максютов", "LNM"),
                new Jumper("Леонов", "DMT"),
                new Jumper("Леонтьев", "ГРМ"),
                new Jumper("Вахрушев", "ДДТ"),
        };

        //Заполнение длины прыжков
        for (int i = 0; i < Jumpers.Length; i++)
        {
            Jumpers[i].SetJumps();
        }

        //Сортировка по месту
        BubbleSort(Jumpers);
        Console.WriteLine($"Фамилия - Общество - Прыжок 1 - Прыжок 2");
        for (int i = Jumpers.Length - 1; i >= 0; i--)
        {
            Jumpers[i].Print();
        }
        Console.ReadKey();
    }

    static void Swap(ref Jumper e1, ref Jumper e2)
    {
        var temp = e1;
        e1 = e2;
        e2 = temp;
    }

    //сортировка пузырьком
    static void BubbleSort(Jumper[] array)
    {
        var len = array.Length;
        for (var i = 1; i < len; i++)
        {
            for (var j = 0; j < len - i; j++)
            {
                if (array[j].GetSumJumps() > array[j + 1].GetSumJumps())
                {
                    Swap(ref array[j], ref array[j + 1]);
                }
            }
        }
    }

    struct Jumper
    {
        private string SecondName;
        private string Company;

        private float[] JumpTrys;

        public Jumper(string secondName, string company)
        {
            SecondName = secondName;
            Company = company;
            JumpTrys = new float[2] { 0f, 0f };
        }

        public void SetJumps()
        {
            for (int i = 0; i < JumpTrys.Length; i++)
            {
                Console.Write($"Введите длину прыжка {i + 1} - Участника {SecondName}: ");
                float jumpValue = float.Parse(Console.ReadLine());

                JumpTrys[i] = jumpValue;
            }
            Console.WriteLine();
        }
        public void Print()
        {
            Console.WriteLine($"{SecondName} - {Company} - {JumpTrys[0]} - {JumpTrys[1]} - ({GetSumJumps()})");
        }

        public float GetSumJumps() => JumpTrys[0] + JumpTrys[1];
    }
}