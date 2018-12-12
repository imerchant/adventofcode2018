using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day11
{
    public class PowerGrid
    {
        private readonly IDictionary<(int, int), long> _cells;

        public long this[(int X, int Y) position] => _cells[position];

        public PowerGrid(int serialNumber)
        {
            _cells = new DefaultDictionary<(int, int), long>(300 * 300, PowerLevelFor);

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
            for (var y = 0; y <= 297; y++)
            {
                for (var x = 0; x <= 297; x++)
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
    }
}