using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day10
{
    public class LightGrid
    {
        public IList<Light> Lights { get; }

        public LightGrid(IList<string> input)
        {
            Lights = input.Select(Light.Parse).ToList();
        }

        public void Tick(int seconds)
        {
            Lights
                .AsParallel()
                .ForAll(x => x.Tick(seconds));
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            var minX = Lights.Min(x => x.X);
            var minY = Lights.Min(x => x.Y);
            builder.AppendLine($"{minX}, {minY}");
            for (var y = minY; y < minY + 10; ++y)
            {
                for (var x = minX; x < minX + 64; ++x)
                {
                    builder.Append(GetChar(x, y));
                }
                builder.AppendLine();
            }

            return builder.ToString();

            char GetChar(int x, int y)
            {
                var light = Lights.FirstOrDefault(l => l.X == x && l.Y == y);
                return light == null ? '.' : '#';
            }
        }
    }
}