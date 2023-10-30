using System;
    {
    int p = 1;
    for (int n = 1; p * n < 30000; n += 3)
    {
        p *= n;
    }
    Console.WriteLine(p);
    Console.ReadKey();
}