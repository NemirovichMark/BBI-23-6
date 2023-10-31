using System;

 public class KontrolWork
{
    public static void Main(string[] args)

    {
        string N = "";
        int uchastniki = 0;
        while (N != "stop")
        {
            ++uchastniki;
            N = (Console.ReadLine());
        }
        double norma = Convert.ToDouble(Console.ReadLine());
        int count_proshli = 0;
        int count_neproshli = 0;
        int count_soshli = 0;
        double ans = 0;
        for (int i = 0; i < uchastniki; i++)
        {
            string result = Console.ReadLine();
            if (result == "-" || result == " ")
            {
                ++count_soshli;
            }
            else
            {
                ans = Convert.ToDouble(result);
                if (ans >= norma)
                {
                    ++count_proshli;
                }
                else if (ans < norma)
                {
                    ++count_neproshli;
                }
            }
            
        }
        Console.WriteLine("{0}\t{1}\t{2}", count_proshli, count_neproshli, count_soshli);
    }
}
