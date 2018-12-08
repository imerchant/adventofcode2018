using System.Collections.Generic;
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
            var builder = new StringBuilder(Value);
            for (var k = 0; k < builder.Length - 1;)
            {
                var first = builder[k];
                var second = builder[k + 1];

                if (UnitsReact(first, second))
                {
                    builder.Remove(k, 2);
                    k = 0;
                }
                else
                {
                    ++k;
                }
            }

            return builder.ToString();
        }

        public string FindShortestPolymer()
        {
            var units = Value.Select(x => char.ToLowerInvariant(x)).Distinct().ToList();

            var variations = new List<string>();
            units
                .AsParallel()
                .Select(x => new Polymer(GetValue(x)).Collapse())
                .ForAll(x => variations.Add(x));

            return variations.OrderBy(x => x.Length).First();

            string GetValue(char ignoreType) => Value.Where(x => char.ToLowerInvariant(x) != ignoreType).AsString();
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