////1 level 1 
//using System;
//struct Members
//{

//    public string _surname;
//    public string _community;
//    public double _result1;
//    public double _result2;


//    public Members (string Surname, string Community, double Result1, double Result2)
//    {
//        _surname = Surname;
//        _community = Community;
//        _result1 = Result1;
//        _result2 = Result2;
//    }
//    public double GetTotalResult()
//    {
//        return _result1 + _result2;
//    }

//    class Program
//    {
//        static void Main()
//        {
//            List<Members> participants = new List<Members>();

//            participants.Add(new Members { _surname = "Adams", _community = "Community 1", _result1 = 1.5, _result2 = 1.1 });
//            participants.Add(new Members { _surname = "Kennedy", _community = "Community 2", _result1 = 1.2, _result2 = 1.3 });
//            participants.Add(new Members { _surname = "Black", _community = "Community 3", _result1 = 1.3, _result2 = 1.1 });
//            participants.Add(new Members { _surname = "Harrison", _community = "Community 4", _result1 = 1.4, _result2 = 1.4 });
//            participants.Add(new Members { _surname = "Daniels", _community = "Community 5", _result1 = 1.2, _result2 = 1.4 });


//            participants.Sort((p1, p2) => p2.GetTotalResult().CompareTo(p1.GetTotalResult()));

//            Console.WriteLine("Place \tSurname \tCommunity\tResult");
//            for (int i = 0; i < participants.Count; i++)
//            {
//                Members participant = participants[i];
//                Console.WriteLine($"{i + 1}\t{participant._surname}\t{participant._community}\t{participant.GetTotalResult()}");
//            }
//        }
//    }
//}
//level 2 num 1
using System;
using System.Collections.Generic;

class Students
{
    private string _name;
    private List<double> _mark;

    public string Name { get { return _name; } set { _name = value; }}

    public List<double> Mark { get { return _mark; } set { _mark = value; }}

    public double GetAverageMark()
    {
        double sum = 0;
        foreach (double score in _mark)
        {
            sum += score;
        }
        return sum / _mark.Count;
    }
}

class Program
{
    static void Main()
    {
        List<Students> students = new List<Students>();

        students.Add(new Students { Name = "Ellis", Mark = new List<double> { 4.3, 4.1, 4.2, 4.1 } });
        students.Add(new Students { Name = "Alan", Mark = new List<double> { 3.3, 4.0, 3.8, 3.9 } });
        students.Add(new Students { Name = "Bernard", Mark = new List<double> { 5, 5, 4.5, 4.2 } });
        students.Add(new Students { Name = "Effy", Mark = new List<double> { 3.1, 3.2, 3.4, 3.5 } });
        students.Add(new Students { Name = "Karen", Mark = new List<double> { 5, 4.9, 5, 5 } });
        students.Add(new Students { Name = "Hanna", Mark = new List<double> { 3, 4, 2, 2 } });


        List<Students> filteredStudents = new List<Students>();
        foreach (Students student in students)
        {
            if (student.GetAverageMark() >= 4)
            {
                filteredStudents.Add(student);
            }
        }

        filteredStudents.Sort((s1, s2) => s2.GetAverageMark().CompareTo(s1.GetAverageMark()));

        Console.WriteLine("Student\t\tMark");
        foreach (Students student in filteredStudents)
        {
            Console.WriteLine($"{student.Name}\t\t{student.GetAverageMark()}");
        }
    }
}








