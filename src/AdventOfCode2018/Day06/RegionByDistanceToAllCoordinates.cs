using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day06
{
    public class RegionByDistanceToAllCoordinates
    {
        private static readonly char[] Tokens = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz~!@$%^&*()-_=+,<>?/".ToCharArray();
        private const int MaxDistanceSum = 10_000;
        private const int InRegion = -1;
        private const int NotInRegion = -2;
        private readonly int _leftmost;
        private readonly int _topmost;
        private readonly int _rightmost;
        private readonly int _bottommost;

        public IDictionary<(int x, int y), int> Map { get; }
        public IList<Coordinate> Coordinates { get; }

        public int SizeOfRegion => Map.Values.Count(x => x != NotInRegion);

        public RegionByDistanceToAllCoordinates(IList<string> input, int maxDistanceSum = MaxDistanceSum)
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

            for (var y = _topmost; y < _bottommost; ++y)
            {
                for (var x = _leftmost; x < _rightmost; ++x)
                {
                    // if (Map.TryGetValue((x, y), out _))
                    //     continue;

                    var sumOfDistances = Coordinates.Sum(c => c.DistanceFrom(x, y));
                    Map[(x, y)] = sumOfDistances < maxDistanceSum
                        ? InRegion
                        : NotInRegion;
                }
            }
        }

        public override string ToString()
        {
            var builder = new StringBuilder().AppendLine();
            for (var y = _topmost; y < _bottommost; ++y)
            {
                for (var x = _leftmost; x < _rightmost; ++x)
                {
                    builder.Append(GetToken(Map[(x, y)]));
                }
                builder.AppendLine();
            }
            return builder.ToString();

            char GetToken(int value)
            {
                switch (value)
                {
                    case -2:
                        return '.';
                    case -1:
                        return '#';
                    default:
                        return Tokens[value];
                }
            }
        }
    }
}