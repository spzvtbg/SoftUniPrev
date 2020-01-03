namespace March2019
{
    using System;

    public class _01_Basketball_Equipment
    {
        public /*static*/ void Main()
        {
            var yearTaks =  int.Parse(Console.ReadLine());
            var sneakers = yearTaks * 0.6;
            var triko = sneakers * 0.8;
            var ball = triko * 0.25;
            var accessoars = ball * 0.2;
            var sum = yearTaks + sneakers + triko + ball + accessoars;

            Console.WriteLine(sum.ToString("f2"));
        }
    }
}
