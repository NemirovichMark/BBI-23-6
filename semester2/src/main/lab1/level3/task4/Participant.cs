namespace semester2.main.lab1.level3.task4;

public struct Participant
{
    private string _surname;
    private long _resultMilliseconds;
    private int _numberGroup;

    public Participant(string surname, string result, int numberGroup)
    {
        _surname = surname;
        _resultMilliseconds = ParseTime(result);
        _numberGroup = numberGroup;
    }

    public long ResultMilliseconds
    {
        get => _resultMilliseconds;
        set => _resultMilliseconds = value;
    }

    public string Surname
    {
        get => _surname;
        set => _surname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public int NumberGroup
    {
        get => _numberGroup;
        set => _numberGroup = value;
    }

    private static long ParseTime(string result)
    {
        string[] parseResult = result.Split(":");
        return Convert.ToInt64(parseResult[0]) * 60000 +
               Convert.ToInt64(parseResult[1]) * 1000 +
               Convert.ToInt64(parseResult[2]);
    }

    private static string ConvertMilliseconds(long milliseconds)
    {
        return $"{milliseconds / 60000}:{milliseconds / 1000 % 60}:{milliseconds % 1000}";
    }

    public static int Compare(Participant participant1, Participant participant2)
    {
        if (participant1.ResultMilliseconds == participant2.ResultMilliseconds)
        {
            return participant1.Surname.CompareTo(participant2.Surname);
        }

        return participant1.ResultMilliseconds.CompareTo(participant2.ResultMilliseconds);
    }

    public string GetString()
    {
        return $"{_surname,-10}{ConvertMilliseconds(_resultMilliseconds),-10}";
    }
}
