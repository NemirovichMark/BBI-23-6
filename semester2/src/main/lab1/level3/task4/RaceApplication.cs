namespace semester2.main.lab1.level3.task4;

public static class RaceApplication
{
    public static void Run()
    {
        Race race = new Race();
        race.ReadGroupsParticipants();
        race.SortGroupsParticipants();
        race.MergeGroupsParticipants();
        race.WriteGroups();
        race.WriteAllParticipantRating();
    }
}
