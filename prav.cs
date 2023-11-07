using System;

{
    Console.Write("количество спортсменов: ");
    int n = int.Parse(Console.ReadLine());

    int best = int.MaxValue;

    for (int i = 1; i <= n; i++)
    {
        Console.Write($" результат спортсмена {i}: ");
        int result = int.Parse(Console.ReadLine());

        if (result < best)
        {
            best = result;
        }
    }

    Console.WriteLine($"лучший результат спортсмена: {best}");



}
    