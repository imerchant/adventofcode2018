using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Inputs
{
    public static partial class Input
    {
        public static IList<string> Day07Parse(string input) => input.SplitLines().ToList();

        public const string Day07 =
@"Step I must be finished before step G can begin.
Step J must be finished before step A can begin.
Step L must be finished before step D can begin.
Step V must be finished before step S can begin.
Step U must be finished before step T can begin.
Step F must be finished before step Z can begin.
Step D must be finished before step A can begin.
Step E must be finished before step Z can begin.
Step C must be finished before step Q can begin.
Step H must be finished before step X can begin.
Step A must be finished before step Z can begin.
Step Z must be finished before step M can begin.
Step P must be finished before step Y can begin.
Step N must be finished before step K can begin.
Step R must be finished before step W can begin.
Step K must be finished before step O can begin.
Step W must be finished before step S can begin.
Step G must be finished before step Q can begin.
Step Q must be finished before step B can begin.
Step S must be finished before step T can begin.
Step B must be finished before step M can begin.
Step T must be finished before step Y can begin.
Step M must be finished before step O can begin.
Step X must be finished before step O can begin.
Step O must be finished before step Y can begin.
Step C must be finished before step O can begin.
Step B must be finished before step O can begin.
Step T must be finished before step O can begin.
Step S must be finished before step X can begin.
Step E must be finished before step K can begin.
Step Q must be finished before step M can begin.
Step E must be finished before step P can begin.
Step Q must be finished before step S can begin.
Step E must be finished before step O can begin.
Step D must be finished before step P can begin.
Step X must be finished before step Y can begin.
Step I must be finished before step U can begin.
Step B must be finished before step X can begin.
Step F must be finished before step T can begin.
Step B must be finished before step T can begin.
Step V must be finished before step R can begin.
Step I must be finished before step Q can begin.
Step I must be finished before step A can begin.
Step M must be finished before step X can begin.
Step Z must be finished before step S can begin.
Step C must be finished before step S can begin.
Step T must be finished before step M can begin.
Step K must be finished before step X can begin.
Step Z must be finished before step P can begin.
Step V must be finished before step H can begin.
Step Z must be finished before step B can begin.
Step M must be finished before step Y can begin.
Step C must be finished before step K can begin.
Step W must be finished before step Y can begin.
Step J must be finished before step Z can begin.
Step Q must be finished before step O can begin.
Step T must be finished before step X can begin.
Step P must be finished before step Q can begin.
Step P must be finished before step K can begin.
Step D must be finished before step M can begin.
Step P must be finished before step N can begin.
Step S must be finished before step B can begin.
Step H must be finished before step Y can begin.
Step R must be finished before step K can begin.
Step G must be finished before step S can begin.
Step P must be finished before step S can begin.
Step C must be finished before step Z can begin.
Step Q must be finished before step Y can begin.
Step F must be finished before step R can begin.
Step N must be finished before step B can begin.
Step G must be finished before step M can begin.
Step E must be finished before step X can begin.
Step D must be finished before step E can begin.
Step D must be finished before step C can begin.
Step U must be finished before step O can begin.
Step H must be finished before step Z can begin.
Step L must be finished before step C can begin.
Step L must be finished before step F can begin.
Step V must be finished before step D can begin.
Step F must be finished before step X can begin.
Step V must be finished before step W can begin.
Step S must be finished before step Y can begin.
Step K must be finished before step T can begin.
Step D must be finished before step Z can begin.
Step C must be finished before step W can begin.
Step V must be finished before step M can begin.
Step F must be finished before step H can begin.
Step A must be finished before step M can begin.
Step G must be finished before step Y can begin.
Step H must be finished before step M can begin.
Step N must be finished before step W can begin.
Step J must be finished before step K can begin.
Step C must be finished before step B can begin.
Step Z must be finished before step Y can begin.
Step L must be finished before step E can begin.
Step G must be finished before step B can begin.
Step Q must be finished before step T can begin.
Step D must be finished before step W can begin.
Step H must be finished before step G can begin.
Step L must be finished before step O can begin.
Step N must be finished before step O can begin.";
    }
}