namespace semester2.main.lab2.level3.task4.race;

public static class RaceApplication
{
    public static void Run()
    {
        Race race = new Race();
        race.ReadGroupsSportsmen();
        race.WriteGroups();
        race.WriteAllSkierWomenRating();
        race.WriteAllSkierMenRating();
        race.WriteAllSportsmenRating();
    }
}
