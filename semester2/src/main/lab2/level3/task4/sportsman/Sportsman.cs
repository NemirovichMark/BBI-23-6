namespace semester2.main.lab2.level3.task4.sportsman;

public record Sportsman(string Surname, long ResultMilliseconds, int NumberGroup)
{
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

    public string GetString()
    {
        return $"{Surname,-10}{ConvertMilliseconds(ResultMilliseconds),-10}";
    }

    public static int Compare(Sportsman sportsman1, Sportsman sportsman2)
    {
        if (sportsman1.ResultMilliseconds == sportsman2.ResultMilliseconds)
        {
            return sportsman1.Surname.CompareTo(sportsman2.Surname);
        }

        return sportsman1.ResultMilliseconds.CompareTo(sportsman2.ResultMilliseconds);
    }
}
