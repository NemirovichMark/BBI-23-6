namespace semester2.main.lab2.level1.task2;

public record Participant(string Surname, int NumberGroup, string SurnameTeacher, long ResultMilliseconds, bool IsNormative)
{
    public static bool CheckNormative(string result, string normative)
    {
        return ParseTime(result) <= ParseTime(normative);
    }

    public static long ParseTime(string result)
    {
        string[] parseResult = result.Split(":");
        return Convert.ToInt64(parseResult[0]) * 60000 +
               Convert.ToInt64(parseResult[1]) * 1000 +
               Convert.ToInt64(parseResult[2]);
    }

    public static string ConvertMilliseconds(long milliseconds)
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
        return
            $"{Surname,-12}{NumberGroup,-5}{SurnameTeacher,-12}{ConvertMilliseconds(ResultMilliseconds),-12}{(IsNormative ? "Да" : "Нет")}";
    }
}
