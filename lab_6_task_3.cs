using System;
using System.Diagnostics.Metrics;

/*
3)Соревнования по футболу между командами проводятся в два этапа. Для  
проведения первого этапа участники разбиваются на две группы по 12 команд.  
Для проведения второго этапа выбирается 6 лучших команд каждой группы по  
результатам первого этапа. Составить список команд участников второго этапа.
*/


namespace lab_6_task_3
{
    class Match
    {
        public struct Team
        {

            public Team()
            {

            }

            static string[] Winners(string[] team, int[] count)
            {
                string[] winners = new string[6];
                int j = 0;
                int i = 0;
                int[] countt = count;
                while (j < 6)
                {
                    if (i < 11) { i++; }
                    else { i = 0; }
                    if (countt[i] == countt.Max()) { countt[i] = 0; winners[j] = team[i]; j++; }
                    if (j == 6) { break; }

                }
                return winners;
            }

            /*
            static void Print_int(int[] team)
            {
                for (int i = 0; i < team.Length; i++) { Console.Write(team[i] + " "); }
                Console.WriteLine();
            }
            */
            static void Print(string[] team)
            {
                for (int i = 0; i < team.Length; i++) { Console.Write(team[i] + " "); }
                Console.WriteLine();
            }

            static string[] Result(string[] teamA, string[] teamB, int[] countA, int[] countB)
            {
                string[] team = new string[12];
                int j = 0; int i = 0;
                for (int k = 0; k < 11; k++)
                {
                    if (i < 6 && j < 6)
                    {
                        if (countA[i] >= countB[j]) { team[k] = teamA[i]; i++; }
                        else { team[k] = teamB[j]; j++; }
                    }
                    else
                    {
                        if (i > 5) { team[k] = teamB[j]; j++; }
                        if (j > 5) { team[k] = teamA[i]; i++; }
                    }
                }
                return team;
            }

            static void Main(string[] args)
            {
                string[] teamA = "A, B, C, D, E, F, G, H, I, J, K, L".Split(", ");
                string[] teamB = "M, N, O, P, Q, R, S, T, U, V, W, X".Split(", ");
                int[] countA = new int[teamA.Length];
                int[] countB = new int[teamB.Length];
                Random rand = new Random();
                for (int i = 0; i < 12; i++) // команда ABC
                {
                    for (int j = 0; j < 12; j++) // команда MNO
                    {
                        if (rand.Next(0, 10) > rand.Next(0, 10)) { countA[i] += 1; }
                        if (rand.Next(0, 10) < rand.Next(0, 10)) { countB[j] += 1; }
                    }
                }

                /*
                Console.Write("Количество побед 1 команды: ");
                Print_int(countA);
                Console.Write(":Количество побед 2 команды: ");
                Print_int(countB);
                */

                Console.WriteLine("Участники 2 этапа: ");
                Print(Result(Winners(teamA, countA), Winners(teamB, countB), countA, countB));

            }

        }
    }
}