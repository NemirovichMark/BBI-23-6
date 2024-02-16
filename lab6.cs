
#region4_lev1
//using System;
//using System.Collections.Generic;
//using System.Text;

//public class Program
//{
//    struct Participant
//    {
//        private string name;
//        private int id;
//        private int best_result;

//        public int Result { get { return best_result; } }

//        public Participant(string name, int i, int res)
//        {
//            this.name = name;
//            id = i;
//            best_result = res;
//        }

//        public int SECOND_RES
//        {
//            get { return best_result; }
//            set
//            {
//                if (value > best_result) best_result = value;
//            }
//        }

//        public void Info()
//        {
//            Console.WriteLine($"результат: {best_result} имя: {name} ");
//        }

//    }

//    static Participant[] Sort(Participant[] list)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            for (int j = i; j < list.Length; j++)
//                if (list[i].Result < list[j].Result)
//                {
//                    Participant person_now = list[j]; // меняем
//                    list[j] = list[i]; // местами
//                    list[i] = person_now; // игроков
//                }
//        }
//        return list;
//    }


//    public static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        Participant[] peoplelist = new Participant[n];

//        for (int i = 0; i < n; i++)
//        {
//            string name_people = Console.ReadLine();
//            int first_res = int.Parse(Console.ReadLine());
//            int second_res = int.Parse(Console.ReadLine());

//            Participant Person = new Participant(name_people, i + 1, first_res);
//            Person.SECOND_RES = second_res;

//            peoplelist[i] = Person;
//        }

//        peoplelist = Sort(peoplelist);

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{i + 1} место:"); ;
//            peoplelist[i].Info();
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}
#endregion

#region4_lev2
//using System;
//using System.Collections.Generic;
//using System.Text;

//struct Sportsman
//{
//    private string name;
//    private double jump1;
//    private double jump2;
//    private double jump3;
//    private double jump4;

//    public Sportsman(string name, double one, double two, double three, double four)
//    {
//        this.name = name;
//        jump1 = one;
//        jump2 = two;
//        jump3 = three;
//        jump4 = four;
//    }


//    public double End_result()
//    {
//        return jump1 + jump2 + jump3 + jump4;
//    }

//    public void Info()
//    {
//        Console.WriteLine($"результат: {jump1 + jump2 + jump3 + jump4} имя: {name} ");
//    }
//}

//public class Program
//{

//    public static int[] SortedGolosa(int[] list, int n)
//    {
//        for (int i = 1; i < n; i++)
//        {
//            for (int j = 0; j < n - i; j++)
//            {
//                if (list[j + 1] > list[j])
//                {
//                    int now = list[j];
//                    list[j] = list[j + 1];
//                    list[j + 1] = now;
//                }
//            }
//        }
//        return list;
//    }

//    static Sportsman[] Sort(Sportsman[] list)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            for (int j = i; j < list.Length; j++)
//                if (list[i].End_result() < list[j].End_result())
//                {
//                    Sportsman person_now = list[j]; // меняем
//                    list[j] = list[i]; // местами
//                    list[i] = person_now; // игроков
//                }
//        }
//        return list;
//    }


//    public static void Main(string[] args)
//    {
//        int n = int.Parse(Console.ReadLine());
//        Sportsman[] peoplelist = new Sportsman[n];

//        for (int i = 0; i < n; i++) //каждый спортсмен
//        {
//            string name_people = Console.ReadLine();
//            double[] result_jumps = new double[4];
//            for (int j = 0; j < 4; j++) //для каждого прыжка
//            {
//                double index = double.Parse(Console.ReadLine()); //коэф сложности этого прыжка
//                int[] golosa = new int[7]; //голоса семи судей
//                for (int s = 0; s < 7; s++)
//                {
//                    int golos = int.Parse(Console.ReadLine());
//                    golosa[s] = golos;
//                }

//                golosa = SortedGolosa(golosa, 7); //сортировка голосов
//                int sum_golos = 0;
//                for (int k = 1; k < 6; k++)
//                {
//                    sum_golos += golosa[k];
//                }

//                result_jumps[j] = sum_golos * index; //записываем итоговый результат прыжка спортсмену
//            }

//            Sportsman person = new Sportsman(name_people, result_jumps[0], result_jumps[1], result_jumps[2], result_jumps[3]);
//            peoplelist[i] = person;
//        }

//        peoplelist = Sort(peoplelist);

//        for (int i = 0; i < n; i++)
//        {
//            Console.Write($"{i + 1} место:"); ;
//            peoplelist[i].Info();
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}
#endregion

#region4_lev3
//using System;
//using System.Collections.Generic;
//using System.Text;

//public class Program
//{
//    struct Participant
//    {
//        private string name;
//        private int result;

//        public int Result { get { return result; } }

//        public Participant(string name, int res)
//        {
//            this.name = name;
//            result = res;
//        }

//        public void Info()
//        {
//            Console.WriteLine($"результат: {result} имя: {name} ");
//        }

//    }

//    static Participant[] Sort(Participant[] list)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            for (int j = i; j < list.Length; j++)
//                if (list[i].Result < list[j].Result)
//                {
//                    Participant person_now = list[j]; // меняем
//                    list[j] = list[i]; // местами
//                    list[i] = person_now; // игроков
//                }
//        }
//        return list;
//    }


//    public static void Main(string[] args)
//    {
//        int n1 = int.Parse(Console.ReadLine());
//        int n2 = int.Parse(Console.ReadLine());
//        Participant[] onegroup = new Participant[n1];
//        Participant[] twogroup = new Participant[n2];
//        Participant[] allgroup = new Participant[n2+n1];

//        for (int i = 0; i < n1; i++)
//        {
//            string name_ = Console.ReadLine();
//            int result_ = int.Parse(Console.ReadLine());

//            Participant Person = new Participant(name_, result_);

//            onegroup[i] = Person;
//            allgroup[i] = Person;
//        }

//        for (int i = 0; i < n2; i++)
//        {
//            string name_ = Console.ReadLine();
//            int result_ = int.Parse(Console.ReadLine());

//            Participant Person = new Participant(name_, result_);

//            twogroup[i] = Person;
//            allgroup[i+n1] = Person;
//        }

//        onegroup = Sort(onegroup);
//        twogroup = Sort(twogroup);
//        allgroup = Sort(allgroup);

//        Console.WriteLine("1 группа:");
//        for (int i = 0; i < n1; i++)
//        {
//            Console.Write($"{i + 1} место:"); ;
//            onegroup[i].Info();
//            Console.WriteLine();
//        }
//        Console.WriteLine();

//        Console.WriteLine("2 группа:");
//        for (int i = 0; i < n2; i++)
//        {
//            Console.Write($"{i + 1} место:"); ;
//            twogroup[i].Info();
//            Console.WriteLine();
//        }
//        Console.WriteLine();

//        Console.WriteLine("Все участники:");
//        for (int i = 0; i < n1+n2; i++)
//        {
//            Console.Write($"{i + 1} место:"); ;
//            allgroup[i].Info();
//            Console.WriteLine();
//        }
//        Console.WriteLine();
//    }
//}
#endregion

