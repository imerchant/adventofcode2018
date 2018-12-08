using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace AdventOfCode2018.Day07
{
    public class StepSet
    {
        private static readonly Regex StepRegex = new Regex(@".*? (?'dependency'[A-Z]) .* (?'step'[A-Z]) ", RegexOptions.Compiled);

        public IDictionary<char, Step> Steps { get; }

        public StepSet(IList<string> input)
        {
            Steps = new DefaultDictionary<char, Step>(id => new Step(id));

            foreach (var line in input)
            {
                var match = StepRegex.Match(line);
                if (!match.Success)
                    throw new Exception($"Could not parse \"{line}\"");

                var stepId = match.Groups["step"].Value[0];
                var dependencyId = match.Groups["dependency"].Value[0];

                Steps[stepId].Dependencies.Add(Steps[dependencyId]);
            }
        }

        public string OrderOfComplete()
        {
            var order = new StringBuilder(Steps.Count);
            var steps = Steps.Values.OrderBy(x => x.Id).ToList();

            do
            {
                var toComplete = steps.First(x => x.CanComplete);
                order.Append(toComplete.Id);
                toComplete.IsComplete = true;
            }
            while (!steps.All(x => x.IsComplete));

            return order.ToString();
        }
    }
}