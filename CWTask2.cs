using System;
abstract class Profession
{
    private string name;
    protected string profession;
    public string Name { get; }
    private int nadbavka;
    public int Nadbavka { get; }
    public Profession(string name, int nadbavka)
    {
        this.name = name;
        this.nadbavka = nadbavka;
    }
    public void PrintInfo()
    {
        Console.WriteLine("Профессия:" + " " + profession + " " + "Имя:" + " " + name + " " + "Зарплата:" + " " + Calculate());
    }
    public abstract int Calculate();
}
class Fireman : Profession
{
    private int dangerous;
    public int Dangerous { get; }
    public Fireman(string name, int nadbavka, int dangerous) : base(name, nadbavka)
    {
        profession = "Fireman";
        this.dangerous = dangerous;
    }
    public override int Calculate()
    {
        return (dangerous + Nadbavka) * 100;
    }
}
class Engineer : Profession
{
    private int category;
    public int Category { get; }
    public Engineer(string name, int category, int nadbavka) : base(name, nadbavka)
    {
        profession = "Engineer";
        this.category = category;
    }
    public override int Calculate()
    {
        return (Nadbavka + category) * 100;
    }
}
class Scientist : Profession
{
    private int degree;
    public int Degree { get; }
    public Scientist(string name, int degree, int nadbavka) : base(name, nadbavka)
    {
        profession = "Scientist";
        this.degree = degree;
    }
    public override int Calculate()
    {
        return (Nadbavka + degree) * 100;
    }
}
class Programm
{
    static void Main(string[] args)
    {
        Profession[] firemen = new Profession[5]
        {
            new Fireman("Саша", 4, 2),
            new Fireman("Миша", 8, 1),
            new Fireman("Вася", 5, 2),
            new Fireman("Артем", 6, 3),
            new Fireman("Сергей", 3, 1)
        };
        SortBySalary(firemen);
        Print(firemen);
        Profession[] engineers = new Profession[]
        {
            new Engineer("Нина", 3, 5),
            new Engineer("Галя", 3, 1),
            new Engineer("Алиса", 4, 3),
            new Engineer("Вова", 2, 1),
            new Engineer("Кирилл", 5, 4)
        };
        SortBySalary(engineers);
        Print(engineers);
        Profession[] scientists = new Profession[]
        {
            new Scientist("НАДЯ", 1, 8),
            new Scientist("Женя", 3, 5),
            new Scientist("Аня", 3, 7),
            new Scientist("Юля", 2, 5),
            new Scientist("Дима", 4, 5)
        };
        SortBySalary(scientists);
        Print(scientists);
        Profession[] professions = new Profession[15];
        for (int i = 0; i < 5; i++)
        {
            professions[i] = firemen[i];
        }
        for (int i = 0; i < 5; i++)
        {
            professions[i + 5] = engineers[i];
        }
        for (int i = 0; i < 5; i++)
        {
            professions[i + 10] = scientists[i];
        }
        SortBySalary(professions);
        Print(professions);
        Console.ReadKey();
    }
    static void SortBySalary(Profession[] professions)
    {
        for (int i = 0; i < professions.Length; i++)
        {
            for (int j = 0; j < professions.Length - 1; j++)
            {
                if (professions[j].Calculate() < professions[j + 1].Calculate())
                {
                    Profession t = professions[j];
                    professions[j] = professions[j + 1];
                    professions[j + 1] = t;
                }
            }
        }
    }
    static void Print(Profession[] professions)
    {
        for (int i = 0; i < professions.Length; i++)
        {
            professions[i].PrintInfo();
        }
        Console.WriteLine();
    }
}
