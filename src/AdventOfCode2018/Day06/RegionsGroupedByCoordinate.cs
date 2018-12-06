using System.Collections.Generic;
using System.Linq;
using System.Text;
using MoreLinq;

namespace AdventOfCode2018.Day06
{
    public class RegionsGroupedByCoordinate
    {
        private static readonly char[] Tokens = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@#$%^&*()-_=+,<>?/".ToCharArray();
        private readonly int _leftmost;
        private readonly int _topmost;
        private readonly int _rightmost;
        private readonly int _bottommost;

        public IDictionary<(int x, int y), int> Map { get; }
        public IList<Coordinate> Coordinates { get; }
        public HashSet<int> Outside { get; }

        public RegionsGroupedByCoordinate(IList<string> input)
        {
            Map = new Dictionary<(int x, int y), int>();
            Coordinates = new List<Coordinate>();

            for (var k = 0; k < input.Count; ++k)
            {
                var coordinate = Coordinate.Parse(input[k], k);
                Coordinates.Add(coordinate);
                Map[(coordinate.X, coordinate.Y)] = coordinate.Id;
            }

            _leftmost = Coordinates.Min(x => x.X) - 1;
            _topmost = Coordinates.Min(x => x.Y) - 1;
            _rightmost = Coordinates.Max(x => x.X) + 2;
            _bottommost = Coordinates.Max(x => x.Y) + 2;
            Outside = new HashSet<int>();

            for (var y = _topmost; y < _bottommost; ++y)
            {
                for (var x = _leftmost; x < _rightmost; ++x)
                {
                    if (Map.TryGetValue((x, y), out _))
                        continue;

                    var closest = Coordinates.MinBy(c => c.DistanceFrom(x, y)).ToList();
                    if (closest.Count > 1)
                    {
                        Map[(x, y)] = -1;
                    }
                    else
                    {
                        Map[(x, y)] = closest.Single().Id;
                    }

                    if (y == _topmost || y == _bottommost - 1 || x == _leftmost || x == _rightmost - 1)
                        Outside.Add(Map[(x, y)]);
                }
            }
        }

        public int SizeOf(Coordinate coordinate)
        {
            if (Outside.Contains(coordinate.Id))
                return -1;

            return Map.Values.Count(x => x == coordinate.Id);
        }

        public override string ToString()
        {
            var builder = new StringBuilder().AppendLine();
            for (var y = _topmost; y < _bottommost; ++y)
            {
                for (var x = _leftmost; x < _rightmost; ++x)
                {
                    var value = Map[(x, y)];
                    var token = value == -1 ? '.' : Tokens[value];
                    builder.Append(token);
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}