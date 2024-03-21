

struct Series
{
    public string _title;
    public int _average;
    public string _description;
    public bool _watched;

    public Series(string title, int averageLength)
    {
        this._title = title;
        this._average = averageLength;
        this._description = "для сериала описание не задано";
        this._watched = false;
    }

    public void ChangeDescription(string newDescription)
    {
        if (newDescription.Length >= 20 && newDescription.Length <= 200)
        {
            _description = newDescription;
            Console.WriteLine($"описание сериала {_title} изменено на: {_description}");
        }
        else
        {
            Console.WriteLine("описание должно содержать от 20 до 200 символов.");
        }
    }

    public void ChangeWatchedState(bool state)
    {
        _watched = state;
        Console.WriteLine($"состояние просмотра сериала {_title} изменено на: {(_watched ? "просмотрено" : "не просмотрено")}");
    }

    public void DisplayInfo()
    {
        Console.WriteLine($"Название сериала: {_title}");
        Console.WriteLine($"Средняя длина серии: {_average} минут");
        Console.WriteLine($"Описание: {_description}");
        Console.WriteLine($"Состояние просмотра: {(_watched ? "просмотрено" : "не просмотрено")}");
  
    }
}

class Program
{
    static void Main()
    {
        List<Series> seriesList = new List<Series>
        {
            new Series("A", 55),
            new Series("B", 45),
            new Series("C", 50),
            new Series("F", 60),
            new Series("D", 50)
        };

        seriesList.Sort((x, y) => x._title.CompareTo(y._title));

        Console.WriteLine("Список сериалов:");

        Console.WriteLine("Название   Длина серии  Описание                        Состояние просмотра ");

        foreach (var series in seriesList)
        {
            Console.WriteLine($" {series._title}              {series._average}       {series._description}  {(series._watched ? "просмотрено" : "не просмотрено")} ");
        }

    }
}



