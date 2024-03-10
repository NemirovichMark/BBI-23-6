using System;

public class Program
{
    struct Members
    {
        private string _name;
        private int _result;

        public int Result() { return _result; }
        public Members(string name, int res) { _name = name; _result = res; }
        public void Information()
        {
            Console.WriteLine($"name: {_name} result: {_result} ");
        }
    }

    static void Sort(Members[] list)
    {
        for (int i = 0; i < list.Length; i++)
        {
            for (int j = i; j < list.Length; j++)
                if (list[i].Result() < list[j].Result())
                {
                    Members person_now = list[j];
                    list[j] = list[i];
                    list[i] = person_now;
                }
        }
    }
    //static void GnomeSort(Members[] list)
    //{
    //    int i = 0;
    //    while (i < list.Length)
    //    {
    //        if (i == 0 || list[i - 1].Result() >= list[i].Result())
    //        {
    //            i++;
    //        }
    //        else
    //        {
    //            Swap(ref list[i], ref list[i - 1]);
    //            i--;
    //        }
    //    }
    //}

    //static void Swap(ref Members a, ref Members b)
    //{
    //    Members t = a;
    //    a = b;
    //    b = t;
    //}

    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of members (team 1) ");
        int number1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the number of members (team 2) ");
        int number2 = int.Parse(Console.ReadLine());

        Members[] team1 = new Members[number1];
        Members[] team2 = new Members[number2];

        for (int i = 0; i < number1; i++)
        {
            Console.WriteLine("Enter a name (team 1)");
            string name_ = Console.ReadLine();

            Console.WriteLine("Enter a result (team 1)");
            int result_ = int.Parse(Console.ReadLine());

            Members person = new Members(name_, result_);

            team1[i] = person;
        }

        for (int i = 0; i < number2; i++)
        {
            Console.WriteLine("Enter a name (team 2)");
            string name_ = Console.ReadLine();

            Console.WriteLine("Enter a result (team 2)");
            int result_ = int.Parse(Console.ReadLine());

            Members person = new Members(name_, result_);

            team2[i] = person;
        }

        Sort(team1);
        Sort(team2);

        
        Members[] allteam = new Members[number1 + number2];
        Array.Copy(team1, 0, allteam, 0, number1);
        Array.Copy(team2, 0, allteam, number1, number2);
        Sort(allteam);

        Console.WriteLine("Team 1:");
        for (int i = 0; i < number1; i++)
        {
            Console.Write($"{i + 1} place: ");
            team1[i].Information();
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("Team 2:");
        for (int i = 0; i < number2; i++)
        {
            Console.Write($"{i + 1} place: ");
            team2[i].Information();
            Console.WriteLine();
        }
        Console.WriteLine();

        Console.WriteLine("All members:");
        for (int i = 0; i < number1 + number2; i++)
        {
            Console.Write($"{i + 1} place: ");
            allteam[i].Information();
            Console.WriteLine();
        }
    }
}