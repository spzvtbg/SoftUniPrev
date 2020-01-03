namespace March2019
{
    using System;

    public class _02_Football_Results
    {
        public /*static*/ void Main()
        {
            var I = Console.ReadLine();
            var II = Console.ReadLine();
            var III = Console.ReadLine();

            var wins = 0;
            var lost = 0;
            var drawn = 0;

            if (I[0] > I[2])
            {
                wins++;
            }
            else if (I[0] < I[2])
            {
                lost++;
            }
            else
            {
                drawn++;
            }

            if (II[0] > II[2])
            {
                wins++;
            }
            else if (II[0] < II[2])
            {
                lost++;
            }
            else
            {
                drawn++;
            }

            if (III[0] > III[2])
            {
                wins++;
            }
            else if (III[0] < III[2])
            {
                lost++;
            }
            else
            {
                drawn++;
            }

            Console.WriteLine($"Team won {wins} games.");
            Console.WriteLine($"Team lost {lost} games.");
            Console.WriteLine($"Drawn games: {drawn}");
        }
    }
}
