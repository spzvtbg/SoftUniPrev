namespace March2019
{
    using System;

    public class _01_Tennisl_Equipment
    {
        public /*static*/ void Main()
        {
            var tennisRacketPrice = decimal.Parse(Console.ReadLine());
            var racketsCount = int.Parse(Console.ReadLine());
            var sneakersCount = int.Parse(Console.ReadLine());
            var raketsPrice = tennisRacketPrice * racketsCount;
            var sneakerPrice = tennisRacketPrice / 6;
            var sneakersPrice = sneakerPrice * sneakersCount;
            var sum = (raketsPrice + sneakersPrice) * 1.2m;
            var player = Math.Floor((sum) / 8);
            var sponsors = Math.Ceiling(sum * 7 / 8);

            Console.WriteLine($"Price to be paid by Djokovic {player}");
            Console.WriteLine($"Price to be paid by sponsors {sponsors}");
        }
    }
}
