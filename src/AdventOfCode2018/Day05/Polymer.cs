using System.Linq;
using System.Text;
using MoreLinq;

namespace AdventOfCode2018.Day05
{
    public class Polymer
    {
        public string Value { get; }

        public Polymer(string input)
        {
            Value = input;
        }

        public string Collapse()
        {
            var current = Value;
            string next = null;
            do
            {
                current = next ?? current;
                next = Collapse(current);
            }
            while (next != current);

            return next;
        }

        public string FindShortestPolymer()
        {
            var units = Value.Select(x => char.ToLowerInvariant(x)).Distinct().ToList();

            var variations = units
                .AsParallel()
                .Select(x => new Polymer(GetValue(x)).Collapse())
                .ToList();

            return variations.OrderBy(x => x.Length).First();

            string GetValue(char ignoreType) => Value.Where(x => char.ToLowerInvariant(x) != ignoreType).AsString();
        }

        internal static string Collapse(string value)
        {
            var builder = new StringBuilder(value);
            for (var k = 0; k < value.Length - 1;)
            {
                var first = value[k];
                var second = value[k + 1];

                if (UnitsReact(first, second))
                {
                    builder.Remove(k, 2);
                    break;
                }
                else
                {
                    ++k;
                }
            }

            return builder.ToString();
        }

        internal static bool UnitsAreSameType(char first, char second)
        {
            return char.ToLowerInvariant(first) == char.ToLowerInvariant(second);
        }

        internal static bool UnitsReact(char first, char second)
        {
            if (!UnitsAreSameType(first, second))
                return false;

            var oneIsUpper = char.IsUpper(first) || char.IsUpper(second);
            var oneIsLower = char.IsLower(first) || char.IsLower(second);

            return oneIsUpper && oneIsLower;
        }
    }
}