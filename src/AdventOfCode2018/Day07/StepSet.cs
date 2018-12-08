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

        public int LengthOfParallelCompletion(int workerCount, int baseOperationCost, Action<int, IEnumerable<(int workerId, char workingOn)>, string> progressDelegate)
        {
            var steps = Steps.Values.OrderBy(x => x.Id).ToList();
            var workers = Enumerable.Range(0, workerCount).Select(x => new Worker(x + 1, baseOperationCost)).ToList();
            var ticks = -1;
            var completed = new StringBuilder();

            do
            {
                ticks++;
                // reset workers that are finished, mark finished steps
                foreach (var worker in workers.Where(x => x.IsDone))
                {
                    worker.WorkingOn.IsComplete = true;
                    completed.Append(worker.WorkingOn.Id);
                    worker.Reset();
                }

                // start new operations
                var idleWorkers = workers.Where(x => x.IsIdle).ToList();
                var canStart = steps.Where(x => x.CanComplete).ToList();
                if (idleWorkers.Any() && canStart.Any())
                {
                    for (var k = 0; k < idleWorkers.Count && k < canStart.Count; ++k)
                    {
                        idleWorkers[k].WorkOn(canStart[k]);
                    }
                }

                // tick all in-progress workers
                foreach (var worker in workers.Where(x => !x.IsIdle))
                {
                    worker.Tick();
                }

                if (progressDelegate != null)
                    progressDelegate(ticks, workers.Select(x => (x.Id, x.WorkingOn?.Id ?? '.')), completed.ToString());
            }
            while (!steps.All(x => x.IsComplete));

            return ticks;
        }
    }
}