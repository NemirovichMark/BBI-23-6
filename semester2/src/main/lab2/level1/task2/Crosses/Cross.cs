namespace semester2.main.lab2.level1.task2.Crosses;

public abstract class Cross
{
    private readonly List<Participant> _participants = new List<Participant>();
    private string _normative;

    public abstract void ReadCrossInfo();

    public abstract void WriteCrossInfo();

    protected void ReadInfo()
    {
        Console.WriteLine("Количество участников:");
        var n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Норматив(m:ss:SSS):");
        _normative = Console.ReadLine() ?? throw new ArgumentNullException();
        Console.WriteLine(
            "Формат ввода информации об участниках:\n" +
            "Фамилия участницы Номер группы Фамилия учителя Результат(m:ss:SSS)\n" +
            "Например, Иванова 13 Петрова 2:14:135"
        );
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine("Информация об участнике под номером " + (i + 1));
            _participants.Add(ParseParticipant(Console.ReadLine() ?? throw new ArgumentNullException()));
        }
    }

    public void SortListParticipants()
    {
        _participants.Sort(Participant.Compare);
    }

    protected void WriteParticipantsTable()
    {
        Console.WriteLine($"{"Фамилия",-10}{"Группа",-7}{"Учитель",-12}{"Результат",-12}Норматив");
        foreach (var participant in _participants)
        {
            Console.WriteLine(participant.GetString());
        }

        Console.WriteLine();
    }

    private Participant ParseParticipant(string stringInfo)
    {
        string[] parseStringInfo = stringInfo.Split();
        return new Participant(
            parseStringInfo[0],
            Convert.ToInt32(parseStringInfo[1]),
            parseStringInfo[2],
            Participant.ParseTime(parseStringInfo[3]),
            Participant.CheckNormative(parseStringInfo[3], _normative)
        );
    }
}
