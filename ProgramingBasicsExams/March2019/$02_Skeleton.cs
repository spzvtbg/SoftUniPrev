namespace March2019
{
    using System;

    public class _02_Skeleton
    {
        public /*static*/ void Main()
        {
            var min = int.Parse(Console.ReadLine());
            var sec = int.Parse(Console.ReadLine());
            var dis = double.Parse(Console.ReadLine());
            var s100m = int.Parse(Console.ReadLine());

            var time = min * 60 + sec;
            var decr = dis / 120;
            var dect = decr * 2.5;
            var ptime = (dis / 100) * s100m - dect;

            if (time >= ptime)
            {
                Console.WriteLine("Marin Bangiev won an Olympic quota!");
                Console.WriteLine($"His time is {ptime:0.000}.");
            }
            else
            {
                Console.WriteLine($"No, Marin failed! He was {ptime - time:0.000} second slower.");
            }
        }
    }
}
