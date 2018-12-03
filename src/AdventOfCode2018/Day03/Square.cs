using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AdventOfCode2018.Day03
{
    public class Square
    {
        private static Regex SquareDetailsRegex = new Regex(@"#(?'id'\d+?) @ (?'x'\d+?),(?'y'\d+?): (?'width'\d+?)x(?'height'\d+?)\b", RegexOptions.Compiled);

        public int Id { get; }
        public int X { get; }
        public int Y { get; }
        public int Width { get; }
        public int Height { get; }

        public ISet<(int X, int Y)> Area { get; }

        private Square(int id, int x, int y, int width, int height)
        {
            Id = id;
            X = x;
            Y = y;
            Width = width;
            Height = height;
            Area = GetArea();
        }

        private ISet<(int X, int Y)> GetArea()
        {
            var area = new HashSet<(int X, int Y)>();
            for (var x = X; x < X + Width; ++x)
            {
                for (var y = Y; y < Y + Height; ++y)
                {
                    area.Add((x, y));
                }
            }
            return area;
        }

        public static Square Parse(string input)
        {
            var match = SquareDetailsRegex.Match(input);
            if (!match.Success)
                throw new Exception($"Could not parse {input} as Square");

            var id = int.Parse(match.Groups["id"].Value);
            var x = int.Parse(match.Groups["x"].Value);
            var y = int.Parse(match.Groups["y"].Value);
            var width = int.Parse(match.Groups["width"].Value);
            var height = int.Parse(match.Groups["height"].Value);

            return new Square(id, x, y, width, height);
        }
    }
}