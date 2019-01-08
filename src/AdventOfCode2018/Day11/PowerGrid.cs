using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day11
{
    public class PowerGrid
    {
        private readonly IDictionary<(int, int), long> _cells;
        private readonly long[,] _sumTable;

        public long this[(int X, int Y) position] => _cells[position];

        public PowerGrid(int serialNumber)
        {
            _cells = new DefaultDictionary<(int, int), long>(300 * 300, PowerLevelFor);

            _sumTable = new long[301, 301];
            for (var x = 1; x <= 300; ++x)
            {
                for (var y = 1; y <= 300; ++y)
                {
                    _sumTable[x, y] = _cells[(x, y)] + _sumTable[x, y - 1] + _sumTable[x - 1, y] - _sumTable[x - 1, y - 1];
                }
            }

            long PowerLevelFor((int X, int Y) position)
            {
                var rackId = position.X + 10;
                long power = rackId * position.Y;
                power += serialNumber;
                power *= rackId;
                return (power / 100) % 10 - 5;
            }
        }

        public (int X, int Y, long Power) FindHighestPower3x3()
        {
            var subgrids = new Dictionary<(int X, int Y), long>();
            for (var y = 1; y <= 298; y++)
            {
                for (var x = 1; x <= 298; x++)
                {
                    subgrids[(x, y)] = PowerOf3x3((x, y));
                }
            }
            var highest = subgrids.OrderByDescending(x => x.Value).First();

            return (highest.Key.X, highest.Key.Y, highest.Value);
        }

        internal long PowerOf3x3((int X, int Y) position)
        {
            var sum = 0L;
            for (var y = position.Y; y < position.Y + 3; y++)
                for (var x = position.X; x < position.X + 3; x++)
                    sum += _cells[(x, y)];
            return sum;
        }

        public string GetSumTable()
        {
            var builder = new StringBuilder();
            for (var y = 0; y <= 300; ++y)
            {
                for (var x = 0; x <= 300; ++x)
                {
                    var value = $"{_sumTable[x,y]}".PadLeft(4, ' ');
                    builder.Append(value).Append(' ');
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }

        public string GetPowers()
        {
            var builder = new StringBuilder();
            for (var y = 0; y <= 300; ++y)
            {
                for (var x = 0; x <= 300; ++x)
                {
                    var power = (x == 0 || y == 0) ? 0L : _cells[(x, y)];
                    var value = $"{power}".PadLeft(4, ' ');
                    builder.Append(value).Append(' ');
                }
                builder.AppendLine();
            }
            return builder.ToString();
        }
    }
}