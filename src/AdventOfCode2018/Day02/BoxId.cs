using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day02
{
    public class BoxId
    {
        public string Value { get; }
        public bool TwoMatch { get; }
        public bool ThreeMatch { get; }

        public BoxId(string value)
        {
            Value = value;
            var letters = value.GroupBy(x => x);
            TwoMatch = letters.Any(x => x.Count() == 2);
            ThreeMatch = letters.Any(x => x.Count() == 3);
        }

        public static string FindCommonLetters(IList<BoxId> ids)
        {
            for (var k = 0; k < ids.Count; ++k)
            {
                for (var j = 0; j < ids.Count; ++j)
                {
                    if (k == j)
                        continue;

                    var left = ids[k].Value;
                    var right = ids[j].Value;
                    if (TryFindCommonFromOnlyOneDifference(left, right, out var common))
                    {
                        return common;
                    }
                }
            }
            throw new Exception("could not find ids that differ by one");

            bool TryFindCommonFromOnlyOneDifference(string left, string right, out string common)
            {
                var builder = new StringBuilder();
                var foundProblem = false;
                try
                {
                    for (var x = 0; x < left.Length; ++x)
                    {
                        if (left[x] == right[x])
                            builder.Append(left[x]);
                        else
                        {
                            if (foundProblem)
                                return false;
                            foundProblem = true;
                        }
                    }
                    return true;
                }
                finally
                {
                    common = builder.ToString();
                }
            }
        }
    }
}