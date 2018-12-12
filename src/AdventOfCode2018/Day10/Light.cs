using System;
using System.Text.RegularExpressions;

namespace AdventOfCode2018.Day10
{
    public class Light
    {
        private readonly int _startingX, _startingY;
        private static readonly Regex LightRegex = new Regex(@"position=<(?'posX'[ -]*\d+?), (?'posY'[ -]*\d+?)> velocity=<(?'velX'[ -]*\d+?), (?'velY'[ -]*\d+?)>", RegexOptions.Compiled);

        public int Id { get; }
        public int X { get; private set; }
        public int Y { get; private set; }

        public (int X, int Y) Velocity { get; }

        public static Light Parse(string input, int index)
        {
            var match = LightRegex.Match(input);
            if (!match.Success)
                throw new Exception($"Could not parse \"{input}\"");

            var posX = int.Parse(match.Groups["posX"].Value);
            var posY = int.Parse(match.Groups["posY"].Value);
            var velX = int.Parse(match.Groups["velX"].Value);
            var velY = int.Parse(match.Groups["velY"].Value);

            return new Light(index, posX, posY, velX, velY);
        }

        private Light(int id, int posX, int posY, int velX, int velY)
        {
            Id = id;
            _startingX = X = posX;
            _startingY = Y = posY;
            Velocity = (velX, velY);
        }

        public void Tick(int seconds)
        {
            var newPosition = PositionAfter(seconds);
            X = newPosition.X;
            Y = newPosition.Y;
        }

        public (int X, int Y) PositionAfter(int seconds)
        {
            var x = _startingX + Velocity.X * seconds;
            var y = _startingY + Velocity.Y * seconds;
            return (x, y);
        }
    }
}