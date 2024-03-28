using System;
abstract class Discipline
{
    public string discipline_;
    public string discipline
    {
        get => discipline_;
        set => discipline_ = value;
    }
}
abstract class Gender
{
    public string gender_;
    public string gender
    {
        get => gender_;
        set => gender_ = value;
    }
}
class Female : Gender
{
    public Female ()
    {
        gender = "Female";
    }
}
class Male : Gender
{
    public Male()
    {
        gender = "Male";
    }
}
class Skiing : Discipline
{
    public Skiing()
    {
        discipline = "Skiing";
    }
}
abstract class Athlete
{
    public Athlete(string s, double r, Gender g, Discipline d)
    {
        surname = s;
        res = r;
        gender_ = g;
        TypeOfSport = d;
    }
    public string getSurname()
    {
        return surname;
    }
    public double getRes()
    {
        return res;
    }
    public Gender getGender()
    {
        return gender_;
    }
    public Discipline getTypeOfSport()
    {
        return TypeOfSport;
    }
    private Gender gender_;
    private Discipline TypeOfSport;
    private string surname;
    private double res;
}
class Skier : Athlete
{
    public Skier(string s, double r, Gender g) 
    : base (s, r, g, new Skiing())
    {}
}
class Skier_m : Skier
{
    public Skier_m(string s, double r)
    : base (s, r, new Male())
    {}
}
class Skier_f : Skier
{
    public Skier_f(string s, double r)
    : base(s, r, new Female())
    { }
}
class Program
{
    static void sort(Athlete[] x, ref int len)
    {
        for (int i = 0; i < len - 1; i++)
        {
            for (int k = 0; k < len - 1 - i; k++)
            {
                if (x[k].getRes() > x[k + 1].getRes())
                {
                    (x[k], x[k + 1]) = (x[k + 1], x[k]);
                }
            }
        }
    }
    static void Read(Athlete[] x, int n, Gender g)
    {
        for (int i = 0; i < n; i++)
        {
            double res;
            string surname;
            Console.WriteLine($"Введите фамилию {i + 1}-го спортсмена");
            surname = Console.ReadLine();
            Console.WriteLine($"Введите результат {i + 1}-го спортсмена");
            res = Convert.ToDouble(Console.ReadLine());
            if (g.gender == "Male")
            {
                x[i] = new Skier_m(surname, res);
            }
            else
            {
                x[i] = new Skier_f(surname, res);
            }
        }
    }
    static void Print(Athlete[] gr1, int n, string TableName)
    {
        Console.WriteLine($"Таблица группы {TableName}");
        Console.WriteLine("----------------------------------------");
        Console.WriteLine("|  Место  |   Фамилия   |   Результат  |");
        Console.WriteLine("----------------------------------------");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"     {i + 1}         {gr1[i].getSurname()}          {gr1[i].getRes()} секунд ");
        }
        Console.WriteLine();
    }
    static void Merge(Athlete[] gr1, Athlete[] gr2, int n, int k, Athlete[] skiers)
    {
        int pos1 = 0;
        int pos2 = 0;
        for (int i = 0; i < n + k; i++)
        {
            if (pos1 == n)
            {
                skiers[i] = gr2[pos2];
                pos2++;
                continue;
            }
            if (pos2 == k)
            {
                skiers[i] = gr1[pos1];
                pos1++;
                continue;
            }
            if (gr1[pos1].getRes() < gr2[pos2].getRes())
            {
                skiers[i] = gr1[pos1];
                pos1++;
            }
            else
            {
                skiers[i] = gr2[pos2];
                pos2++;
            }
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество лыжниц в 1-ой группе");
        int n = Convert.ToInt32(Console.ReadLine());
        Athlete[] f1 = new Athlete[n];
        Read(f1, n, new Female());

        Console.WriteLine("Введите количество лыжниц в 2-ой группе");
        int k = Convert.ToInt32(Console.ReadLine());
        Athlete[] f2 = new Athlete[k];
        Read(f2, k, new Female());

        Console.WriteLine("Введите количество лыжников в 1-ой группе");
        int p = Convert.ToInt32(Console.ReadLine());
        Athlete[] m1 = new Athlete[p];
        Read(m1, p, new Male());

        Console.WriteLine("Введите количество лыжников в 2-ой группе");
        int d = Convert.ToInt32(Console.ReadLine());
        Athlete[] m2 = new Athlete[d];
        Read(m2, d, new Male());

        sort(f1, ref n);
        sort(f2, ref k);
        sort(m1, ref p);
        sort(m2, ref d);

        Print(f1, n, "Лыжницы-1");
        Print(f2, k, "Лыжницы-2");
        Print(m1, p, "Лыжники-1");
        Print(m2, d, "Лыжники-2");

        Athlete[] f12 = new Athlete[n + k];
        Merge(f1, f2, n, k, f12);
        Print(f12, n + k, "Лыжницы-12");
        Athlete[] m12 = new Athlete[p + d];
        Merge(m1, m2, p, d, m12);
        Print(m12, p + d, "Лыжники-12");

        Athlete[] all = new Athlete[n + k + p + d];
        Merge(f12, m12, n + k, p + d, all);
        Print(all, n + k + p + d, "Лыжники+Лыжницы");
    }
}