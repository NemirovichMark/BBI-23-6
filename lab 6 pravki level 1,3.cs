////level 3 num 4
//public class Program
//{
//    struct Members
//    {
//        private string _name;
//        private int _result;
//        public int Result() {return _result;}
//        public Members(string name, int res){_name = name;_result = res;}
//        public void Information()
//        {
//            Console.WriteLine($"name: {_name} result: {_result} ");
//        }
//    }
//    static Members[] Sort(Members[] list)
//    {
//        for (int i = 0; i < list.Length; i++)
//        {
//            for (int j = i; j < list.Length; j++)
//                if (list[i].Result() < list[j].Result())
//                {
//                    Members person_now = list[j];  
//                    list[j] = list[i];
//                    list[i] = person_now;
//                }
//        }
//        return list;
//    }
//    public static void Main(string[] args)
//    {
//        Console.WriteLine("enter the number of members (team 1) ");

//        int number1 = int.Parse(Console.ReadLine());
//        Console.WriteLine("enter the number of members (team 2) ");

//        int number2 = int.Parse(Console.ReadLine());
//        Members[] team1 = new Members[number1];
//        Members[] team2 = new Members[number2];
//        Members[] allteam = new Members[number1 + number2];

//        for (int i = 0; i < number1; i++)
//        {
//            Console.WriteLine("enter a name (team 1)");

//            string name_ = Console.ReadLine();
//            Console.WriteLine("enter a result (team 1)");

//            int result_ = int.Parse(Console.ReadLine());

//            Members Person = new Members(name_, result_);

//            team1[i] = Person;
//            allteam[i] = Person;
//        }

//        for (int i = 0; i < number2; i++)
//        {

//            Console.WriteLine("enter a name (team 2)");
//            string name_ = Console.ReadLine();
//            Console.WriteLine("enter a result (team 2)");

//            int result_ = int.Parse(Console.ReadLine());

//            Members Person = new Members(name_, result_);

//            team2[i] = Person;
//            allteam[i + number1] = Person;
//        }

//        team1 = Sort(team1);
//        team2 = Sort(team2);
//        allteam = Sort(allteam);

//        Console.WriteLine("team 1:");
//        for (int i = 0; i < number1; i++)
//        {
//            Console.Write($"{i + 1} place:"); ;
//            team1[i].Information();
//            Console.WriteLine();
//        }
//        Console.WriteLine();

//        Console.WriteLine("team 2:");
//        for (int i = 0; i < number2; i++)
//        {
//            Console.Write($"{i + 1} place:"); ;
//            team2[i].Information();
//            Console.WriteLine();
//        }
//        Console.WriteLine();

//        Console.WriteLine("All members:");
//        for (int i = 0; i < number1 + number2; i++)
//        {
//            Console.Write($"{i + 1} place:"); ;
//            allteam[i].Information();
//            Console.WriteLine();
//        }
        
//    }
//}

// 1 level 1  
struct Members
{
    private string _surname;
    private string _community;
    private double _result1;
    private double _result2;

    public string Surname { get { return _surname; } set { _surname = value; } }

    public string Community { get { return _community; } set { _community = value; } }

    public double Result1 { get { return _result1; } set { _result1 = value; } }

    public double Result2 { get { return _result2; } set { _result2 = value; } }
    public double GetTotalResult()
    {
        return Result1 + Result2;
    }
    class Program
    {
        static void Main()
        {
            List<Members> participants = new List<Members>();

            participants.Add(new Members { _surname = "Adams", _community = "Community 1", _result1 = 1.5, _result2 = 1.1 });
            participants.Add(new Members { _surname = "Kennedy", _community = "Community 2", _result1 = 1.2, _result2 = 1.3 });
            participants.Add(new Members { _surname = "Black", _community = "Community 3", _result1 = 1.3, _result2 = 1.1 });
            participants.Add(new Members { _surname = "Harrison", _community = "Community 4", _result1 = 1.4, _result2 = 1.4 });
            participants.Add(new Members { _surname = "Daniels", _community = "Community 5", _result1 = 1.2, _result2 = 1.4 });


            participants.Sort((p1, p2) => p2.GetTotalResult().CompareTo(p1.GetTotalResult()));

            Console.WriteLine("Place \tSurname \tCommunity\tResult");
            for (int i = 0; i < participants.Count; i++)
            {
                Members participant = participants[i];
                Console.WriteLine($"{i + 1}\t{participant._surname}\t{participant._community}\t{participant.GetTotalResult()}");
            }
        }
    }
}