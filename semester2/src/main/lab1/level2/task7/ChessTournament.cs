namespace semester2.main.lab1.level2.task7;

public class ChessTournament
{
    private readonly Dictionary<string, int> _chessPlayersDictionary = new Dictionary<string, int>();
    private ChessPlayer[] _chessPlayers;

    public void ReadInfoTournament()
    {
        Console.WriteLine("Количество участников:");
        int n = Convert.ToInt32(Console.ReadLine());
        _chessPlayers = new ChessPlayer[n];
        Console.WriteLine("Фамилии участников, каждая с новой строки:");
        for (int i = 0; i < n; i++)
        {
            string surname = Console.ReadLine() ?? throw new ArgumentNullException();
            _chessPlayersDictionary.Add(surname, i);
            _chessPlayers[i] = new ChessPlayer(surname);
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
            _chessPlayers[_chessPlayersDictionary[infoGames[0]]].Win();
            _chessPlayers[_chessPlayersDictionary[infoGames[1]]].Lose();
        }
        else if (infoGames[2].Equals("win2") || infoGames[2].Equals("lose1"))
        {
            _chessPlayers[_chessPlayersDictionary[infoGames[0]]].Lose();
            _chessPlayers[_chessPlayersDictionary[infoGames[1]]].Win();
        }
        else
        {
            _chessPlayers[_chessPlayersDictionary[infoGames[0]]].Draw();
            _chessPlayers[_chessPlayersDictionary[infoGames[1]]].Draw();
        }
    }

    public void SortChessPlayersArray()
    {
        Array.Sort(_chessPlayers, ChessPlayer.Compare);
    }

    public void WriteChessPlayersTable()
    {
        Console.WriteLine($"{"Место", -7}{"Фамилия", -8}{"Игры", -5}{"Очки"}");
        int i = 0;

        foreach (var chessPlayer in _chessPlayers.OrderByDescending(x => x.NumberPoints))
        {
            Console.WriteLine($"{++i, -7}" + chessPlayer.GetString());
        }
    }
}
