using System;

namespace AdventOfCode2018.Day06
{
    public class Coordinate
    {
        public int Id { get; }
        public int X { get; }
        public int Y { get; }

        private Coordinate(int id, int x, int y)
        {
            Id = id;
            X = x;
            Y = y;
        }

        public int DistanceFrom(int a, int b)
        {
            return Math.Abs(a - X) + Math.Abs(b - Y);
        }

        public static Coordinate Parse(string input, int index)
        {
            var split = input.SplitOn(',');
            return new Coordinate(index, int.Parse(split[0]), int.Parse(split[1]));
        }
    }
}