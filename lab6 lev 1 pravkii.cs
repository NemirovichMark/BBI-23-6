1 level 1 
using System;
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
