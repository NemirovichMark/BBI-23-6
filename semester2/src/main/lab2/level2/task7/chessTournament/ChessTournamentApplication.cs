namespace semester2.main.lab2.level2.task7.chessTournament;

public static class ChessTournamentApplication
{
    public static void Run()
    {
        var chessTournament = new ChessTournament();
        chessTournament.ReadInfoTournament();
        chessTournament.SortChessPlayersArray();
        chessTournament.WriteChessPlayersTable();
    }
}
