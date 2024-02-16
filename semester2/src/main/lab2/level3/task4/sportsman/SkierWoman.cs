namespace semester2.main.lab2.level3.task4.sportsman;

public record SkierWoman(string Surname, long ResultMilliseconds, int NumberGroup)
    : Sportsman(Surname, ResultMilliseconds, NumberGroup);
