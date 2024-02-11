namespace semester2.main.lab1.level1.task2;

public struct Participant
{
    private string _surname;
    private string _surnameTeacher;
    private int _numberGroup;
    private long _resultMilliseconds;
    private bool _isNormative;

    public Participant(string surname, int numberGroup, string surnameTeacher, string result, string normative)
    {
        _surname = surname;
        _surnameTeacher = surnameTeacher;
        _numberGroup = numberGroup;
        _resultMilliseconds = ParseTime(result);
        _isNormative = _resultMilliseconds <= ParseTime(normative);
    }

    public bool IsNormative
    {
        get => _isNormative;
        set => _isNormative = value;
    }

    public long ResultMilliseconds
    {
        get => _resultMilliseconds;
        set => _resultMilliseconds = value;
    }

    public int NumberGroup
    {
        get => _numberGroup;
        set => _numberGroup = value;
    }

    public string SurnameTeacher
    {
        get => _surnameTeacher;
        set => _surnameTeacher = value ?? throw new ArgumentNullException(nameof(value));
    }

    public string Surname
    {
        get => _surname;
        set => _surname = value ?? throw new ArgumentNullException(nameof(value));
    }

    private string GetIsNormative()
    {
        return _isNormative ? "Да" : "Нет";
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

    public string GetString()
    {
        return
            $"{_surname,-12}{_numberGroup,-5}{_surnameTeacher,-12}{ConvertMilliseconds(_resultMilliseconds),-12}{GetIsNormative()}";
    }

    public static int Compare(Participant participant1, Participant participant2)
    {
        if (participant1.ResultMilliseconds == participant2.ResultMilliseconds)
        {
            return participant1.Surname.CompareTo(participant2.Surname);
        }

        return participant1.ResultMilliseconds.CompareTo(participant2.ResultMilliseconds);
    }
}
