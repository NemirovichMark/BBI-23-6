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
class LongJump : Discipline
{
    public LongJump()
    {
        discipline = "Long jump";
    }
}
class HighJump : Discipline
{
    public HighJump()
    {
        discipline = "High jump";
    }
}
struct Sportsman
{

    public Sportsman(string s, Discipline d, double r1, double r2, double r3)
    {
        surname = s;
        TypeOfSport = d;
        res1 = r1;
        res2 = r2;
        res3 = r3;
    }
    public double getMax()
    {
        if (res1 >= res2 && res1 >= res3)
        {
            return res1;
        }
        else if (res2 >= res1 && res2 >= res3)
        {
            return res2;
        }
        else
        {
            return res3;
        }
    }
    public string getSurname()
    {
        return surname;
    }
    public double getFirst()
    {
        return res1;
    }
    public double getSecond()
    {
        return res2;
    }
    public double getThird()
    {
        return res3;
    }
    private Discipline TypeOfSport;
    private string surname;
    private double res1, res2, res3;
}
class Program
{
    static void Read(int n, Sportsman[] sportsmen, Discipline d)
    {
        Console.WriteLine($"Введите спортсменов, учавствующих в дисциплине {d}");
        for (int i = 0; i < n; i++)
        {
            double res1, res2, res3;
            string surname;
            Console.WriteLine($"Введите фамилию {i + 1}-го спортсмена");
            surname = Console.ReadLine();
            Console.WriteLine($"Введите первый результат {i + 1}-го спортсмена");
            res1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите второй результат {i + 1}-го спортсмена");
            res2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine($"Введите третий результат {i + 1}-го спортсмена");
            res3 = Convert.ToDouble(Console.ReadLine());
            sportsmen[i] = new Sportsman(surname, d, res1, res2, res3);
        }
    }
    static void Print(Sportsman[] sportsmen, int n)
    {
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"{sportsmen[i].getSurname()}, лучший результат: {sportsmen[i].getMax()} м");
        }
    }
    static void Main(string[] args)
    {
        Console.WriteLine("Введите количество спортсменов, учавствующих в дисциплине Long Jump");
        int n = Convert.ToInt32(Console.ReadLine());
        Sportsman[] LongJumpers = new Sportsman[n];
        Read(n, LongJumpers, new LongJump());
        Console.WriteLine("Прыжки в длину");
        Print(LongJumpers, n);

        Console.WriteLine("Введите количество спортсменов, учавствующих в дисциплине High Jump");
        int k = Convert.ToInt32(Console.ReadLine());
        Sportsman[] HighJumpers = new Sportsman[k];
        Read(n, HighJumpers, new LongJump());
        Console.WriteLine("Прыжки в высоту");
        Print(HighJumpers, k);
    }
}