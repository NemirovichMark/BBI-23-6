using System;
using System.Xml.Linq;
static class Hello
{

    //задание 1.1

    //public abstract class Sportsmen
    //{
    //    string famile;
    //    string name;
    //    double rez1, rez2;
    //    public Sportsmen(string famile1, string name1)
    //    {
    //        famile = famile1;
    //        name = name1;
    //    }
    //    public string getfamile { get { return famile; } }
    //    public string getname { get { return name; } }

    //}

    //class Result : Sportsmen
    //{
    //    double rez;
    //    public Result(string famile1, string name1, double rezz1, double rezz2) : base(famile1, name1)
    //    {
    //        rez = rezz1 + rezz2;
    //    }
    //    public double GetRez()
    //    {
    //        return rez;
    //    }
    //    public void Print()
    //    {
    //        Console.WriteLine($"{getfamile} {getname} {rez}");
    //    }
    //}

    //static Result[] Sort(Result[] sport)
    //{
    //    for (int i = 0; i < sport.Length; i++)
    //    {
    //        for (int j = i; j < sport.Length; j++)
    //        {
    //            if (sport[i].GetRez() < sport[j].GetRez())
    //            {
    //                Result student = sport[j];
    //                sport[j] = sport[i];
    //                sport[i] = student;
    //            }
    //        }
    //    }
    //    return sport;
    //}

    //public static void Main()
    //{
    //    Result[] sp = new Result[5];
    //    sp[0] = new Result("Иванов", "Дмитрий", 3.15, 3.7);
    //    sp[1] = new Result("Дорогой", "Александр", 4.12, 4.20);
    //    sp[2] = new Result("Бруталов", "Фофан", 2.98, 3.34);
    //    sp[3] = new Result("Палец", "Безымянный", 3.19, 3.11);
    //    sp[4] = new Result("Просто", "Спортсмен", 5.11, 6.00);
    //    for (int i = 0; i < sp.Length; i++)
    //    {
    //        sp[i].Print();
    //    }
    //    sp = Sort(sp);
    //    Console.WriteLine();
    //    for (int i = 0; i < sp.Length; i++)
    //    {
    //        sp[i].Print();
    //    }
    //}

    //задание 2.2

    //public abstract class Students //класс родитель хранит фамилию, имя учеников
    //{
    //    string famile;
    //    string name;

    //    public Students(string famile1, string name1)
    //    {
    //        famile = famile1; name = name1;
    //    }
    //    public string Getfamile { get { return famile; } }
    //    public string Getname { get { return name; } }

    //}
    //class Results : Students //заимствованный класс для результатов экзов
    //{
    //    double rez, rez1, rez2, rez3;
    //    public Results(string famile1, string name1, double rezz1, double rezz2, double rezz3) : base(famile1, name1)
    //    {
    //        rez1 = rezz1; rez2 = rezz2; rez3 = rezz3;
    //        rez = (rezz1 + rezz2 + rezz3) / 3;
    //    }
    //    public double GetRez()
    //    {
    //        return rez;
    //    }
    //    public void Print()
    //    {
    //        Console.WriteLine($"{Getfamile} {Getname} {rez}");
    //    }
    //    public bool PResults()
    //    {
    //        if (rez1 <= 2 || rez2 <= 2 || rez3 <= 2)
    //        {
    //            return true;
    //        }
    //        else return false;
    //    }
    //}

    //static Results[] Sort(Results[] students) //сортировка изначального списка
    //{
    //    for (int i = 0; i < students.Length; i++)
    //    {
    //        for (int j = i; j < students.Length; j++)
    //        {
    //            if (students[i].GetRez() < students[j].GetRez())
    //            {
    //                Results student = students[j];
    //                students[j] = students[i];
    //                students[i] = student;
    //            }
    //        }
    //    }
    //    return students;
    //}

    //public static void Main()
    //{
    //    Results[] st = new Results[5];
    //    st[0] = new Results("Иванов", "Дмитрий", 3, 3, 4);
    //    st[1] = new Results("Дорогой", "Александр", 4, 4, 5);
    //    st[2] = new Results("Бруталов", "Фофан", 2, 3, 4);
    //    st[3] = new Results("Палец", "Безымянный", 3, 3, 3);
    //    st[4] = new Results("Просто", "Спортсмен", 5, 2, 4);
    //    st = Sort(st);
    //    for (int i = 0; i < st.Length; i++)
    //    {
    //        st[i].Print();
    //    }
    //    Console.WriteLine();
    //    for (int i = 0; i < st.Length; i++)
    //    {
    //        if (st[i].PResults())
    //        {

    //        }
    //        else
    //        {
    //            st[i].Print();
    //        }
    //    }
    //}

    //задание 3.4

    //public class Program
    //{
    //    public abstract class Person
    //    {
    //        protected string name;
    //        public Person(string name_) 
    //        {
    //            name = name_;
    //        }
    //        public string Name { get { return name; } }
    //    }
    //    class Participant : Person
    //    {
    //        protected int result;
    //        public Participant(string name_, int results_) : base(name_)
    //        {
    //            result = results_;
    //        }
    //        public int GetResult()
    //        {
    //            return result;
    //        }
    //        public void InfoP()
    //        {
    //            Console.WriteLine($"имя: {Name} результат: {result} ");
    //        }
    //    }

    //    static Participant[] Sort(Participant[] list)
    //    {
    //        for (int i = 0; i < list.Length; i++)
    //        {
    //            for (int j = i; j < list.Length; j++)
    //                if (list[i].GetResult() < list[j].GetResult())
    //                {
    //                    Participant person_now = list[j]; // меняем игроков 
    //                    list[j] = list[i];
    //                    list[i] = person_now;
    //                }
    //        }
    //        return list;
    //    }
    //    public static void Main(string[] args)
    //    {
    //        int n1 = int.Parse(Console.ReadLine());
    //        int n2 = int.Parse(Console.ReadLine());
    //        Participant[] group1 = new Participant[n1];
    //        Participant[] group2 = new Participant[n2];
    //        Participant[] allgroup = new Participant[n2 + n1];

    //        for (int i = 0; i < n1; i++)
    //        {
    //            string name_ = Console.ReadLine();
    //            int result_ = int.Parse(Console.ReadLine());

    //            Participant Person = new Participant(name_, result_);

    //            group1[i] = Person;
    //            allgroup[i] = Person;
    //        }

    //        for (int i = 0; i < n2; i++)
    //        {
    //            string name_ = Console.ReadLine();
    //            int result_ = int.Parse(Console.ReadLine());

    //            Participant Person = new Participant(name_, result_);

    //            group2[i] = Person;
    //            allgroup[i + n1] = Person;
    //        }

    //        group1 = Sort(group1);
    //        group2 = Sort(group2);
    //        allgroup = Sort(allgroup);

    //        Console.WriteLine("1 группа:");
    //        for (int i = 0; i < n1; i++)
    //        {
    //            Console.Write($"{i + 1} место:"); ;
    //            group1[i].InfoP();
    //            Console.WriteLine();
    //        }
    //        Console.WriteLine();

    //        Console.WriteLine("2 группа:");
    //        for (int i = 0; i < n2; i++)
    //        {
    //            Console.Write($"{i + 1} место:"); ;
    //            group2[i].InfoP();
    //            Console.WriteLine();
    //        }
    //        Console.WriteLine();

    //        Console.WriteLine("Все участники:");
    //        for (int i = 0; i < n1 + n2; i++)
    //        {
    //            Console.Write($"{i + 1} место:"); ;
    //            allgroup[i].InfoP();
    //            Console.WriteLine();
    //        }
    //        Console.WriteLine();
    //    }
    //}
}