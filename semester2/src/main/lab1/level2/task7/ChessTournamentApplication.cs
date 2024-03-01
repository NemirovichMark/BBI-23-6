namespace semester2.main.lab1.level2.task7;

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
