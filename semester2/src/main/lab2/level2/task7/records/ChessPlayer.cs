namespace semester2.main.lab2.level2.task7.records;

public record ChessPlayer(string Surname, int Id) : Sportsman(Surname)
{
    private int _numberGames;
    private double _numberPoints;

    public int NumberGames
    {
        get => _numberGames;
        set => _numberGames = value;
    }

    public double NumberPoints
    {
        get => _numberPoints;
        set => _numberPoints = value;
    }

    public void Result(string result, int numberPlayer)
    {
        if (numberPlayer == 1)
        {
            if (result.Equals("win1") || result.Equals("lose2"))
            {
                _numberPoints++;
                _numberGames++;
            }
            else if (result.Equals("win2") || result.Equals("lose1"))
            {
                _numberGames++;
            }
            else
            {
                _numberPoints += 0.5;
                _numberGames++;
            }
        }
        else
        {
            if (result.Equals("win2") || result.Equals("lose1"))
            {
                _numberPoints++;
                _numberGames++;
            }
            else if (result.Equals("win1") || result.Equals("lose2"))
            {
                _numberGames++;
            }
            else
            {
                _numberPoints += 0.5;
                _numberGames++;
            }
        }
    }

    public string GetString()
    {
        return $"{Surname,-12}{Id, -8}{_numberGames,-7}{_numberPoints}";
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