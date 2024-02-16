using semester2.main.lab2.level2.task7.records;
namespace semester2.main.lab2.level2.task7.chessTournament;

public class ChessTournament
{
    private readonly Dictionary<string, ChessPlayer> _chessPlayersDictionary = new Dictionary<string, ChessPlayer>();
    private readonly List<ChessPlayer> _chessPlayers = new List<ChessPlayer>();

    public void ReadInfoTournament()
    {
        Console.WriteLine("Количество участников:");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Информация об игроках:\n" +
                          "Фамилия Номер игрока\n" +
                          "Например, Иванов 1234");
        for (int i = 0; i < n; i++)
        {
            string[] info = (Console.ReadLine() ?? throw new ArgumentNullException()).Split();
            ChessPlayer chessPlayer = new ChessPlayer(info[0], Convert.ToInt32(info[1]));
            _chessPlayersDictionary.Add(chessPlayer.Surname, chessPlayer);
            _chessPlayers.Add(chessPlayer);
        }

        Console.WriteLine("Информация о партиях в формате:\n" +
                          "Игрок1 Игрок2 Результат(win1(lose2), win2(lose1), draw)\n" +
                          "Например, Иванов Петров win1\n" +
                          "Введите END, если вы ввели информацию о всех партиях");
        ReadGamesInfo();
    }

    private void ReadGamesInfo()
    {
        int numberChessGame = 1;
        while (true)
        {
            Console.WriteLine($"Партия {numberChessGame++}");
            String info = Console.ReadLine() ?? throw new ArgumentNullException();
            if (info.ToLower().Equals("end"))
            {
                break;
            }

            Parse(info);
        }
    }

    private void Parse(string info)
    {
        string[] infoGames = info.Split();
        if (infoGames[2].Equals("win1") || infoGames[2].Equals("lose2"))
        {
            _chessPlayersDictionary[infoGames[0]].Win();
            _chessPlayersDictionary[infoGames[1]].Lose();
        }
        else if (infoGames[2].Equals("win2") || infoGames[2].Equals("lose1"))
        {
            _chessPlayersDictionary[infoGames[0]].Lose();
            _chessPlayersDictionary[infoGames[1]].Win();
        }
        else
        {
            _chessPlayersDictionary[infoGames[0]].Draw();
            _chessPlayersDictionary[infoGames[1]].Draw();
        }
    }

    public void SortChessPlayersArray()
    {
        _chessPlayers.Sort(ChessPlayer.Compare);
    }

    public void WriteChessPlayersTable()
    {
        Console.WriteLine($"{"Место", -7}{"Фамилия", -12}{"Номер", -8}{"Игры", -7}Очки");
        int i = 0;

        foreach (var chessPlayer in _chessPlayers.OrderByDescending(x => x.NumberPoints))
        {
            Console.WriteLine($"{++i, -7}" + chessPlayer.GetString());
        }
    }
}
