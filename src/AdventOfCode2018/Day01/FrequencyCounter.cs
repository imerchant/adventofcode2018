using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day01
{
    public class FrequencyCounter
    {
        public IList<Mutation> Mutations { get; }
        public int Sum { get; }

        public FrequencyCounter(IList<string> input)
        {
            Mutations = input.Select(Mutation.Parse).ToList();
            Sum = Mutations.Sum(x => x.Value);
        }

        public int FindFirstDuplicate()
        {
            var seenValues = new HashSet<int>();
            var frequency = 0;
            seenValues.Add(frequency);

            for (var k = 0; k < 10_000_000; k++)
            {
                frequency += Mutations[k % Mutations.Count].Value;
                if (!seenValues.Add(frequency))
                    return frequency;
            }
            throw new Exception("could not find a duplicate");
        }
    }
}