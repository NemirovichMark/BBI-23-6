namespace semester2.main.lab1.level2.task7;

public struct ChessPlayer
{
    private string _surname;
    private int _numberGames;
    private double _numberPoints;

    public ChessPlayer(string surname)
    {
        _surname = surname;
    }

    public double NumberPoints
    {
        get => _numberPoints;
        set => _numberPoints = value;
    }

    public int NumberGames
    {
        get => _numberGames;
        set => _numberGames = value;
    }

    public string Surname
    {
        get => _surname;
        set => _surname = value ?? throw new ArgumentNullException(nameof(value));
    }

    public void Win()
    {
        _numberPoints++;
        _numberGames++;
    }

    public void Draw()
    {
        _numberPoints += 0.5;
        _numberGames++;
    }

    public void Lose()
    {
        _numberGames++;
    }

    public string GetString()
    {
        return $"{_surname,-10}{_numberGames,-5}{_numberPoints}";
    }

    public static int Compare(ChessPlayer chessPlayer1, ChessPlayer chessPlayer2)
    {
        if (Math.Abs(chessPlayer1.NumberPoints - chessPlayer2.NumberPoints) < 0.01)
        {
            if (chessPlayer1.NumberGames == chessPlayer2.NumberGames)
            {
                return chessPlayer1.Surname.CompareTo(chessPlayer2.Surname);
            }
            return chessPlayer1.NumberGames.CompareTo(chessPlayer2.NumberGames);
        }
        return chessPlayer2.NumberPoints.CompareTo(chessPlayer1.NumberPoints);
    }
}
