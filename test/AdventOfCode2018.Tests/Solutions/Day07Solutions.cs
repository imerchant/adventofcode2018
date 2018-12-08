using System.Collections.Generic;
using System.Linq;
using AdventOfCode2018.Day07;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day07Solutions : TestBase
    {
        public Day07Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle1_FindOrderOfStepCompletion()
        {
            var set = new StepSet(Input.Day07Parse(Input.Day07));

            var order = set.OrderOfComplete();

            order.Should().Be("IJLFUVDACEHGRZPNKQWSBTMXOY");
        }

        [Fact]
        public void Puzzle2_FindSecondsToCompleteWork()
        {
            const int workerCount = 5;
            const int baseOperationCost = 60;
            var set = new StepSet(Input.Day07Parse(Input.Day07));

            var seconds = set.LengthOfParallelCompletion(workerCount, baseOperationCost, null);

            seconds.Should().Be(1072);
        }

        public const string PuzzleExample =
@"Step C must be finished before step A can begin.
Step C must be finished before step F can begin.
Step A must be finished before step B can begin.
Step A must be finished before step D can begin.
Step B must be finished before step E can begin.
Step D must be finished before step E can begin.
Step F must be finished before step E can begin.";

        [Fact]
        public void Puzzle2Example_CompletesWorkIn15Seconds()
        {
            Output.WriteLine("");
            const int workerCount = 2;
            const int baseOperationCost = 0;
            var set = new StepSet(Input.Day07Parse(PuzzleExample));

            var time = set.LengthOfParallelCompletion(workerCount, baseOperationCost, PrintProgress);

            time.Should().Be(15);

            void PrintProgress(int ticks, IEnumerable<(int workerId, char workingOn)> workerStatus, string completed)
            {
                Output.WriteLine($"{ticks:###00} | {workerStatus.Select(x => $"{x.workerId}: {x.workingOn}").JoinStrings(" ")} | {completed}");
            }
        }

        [Fact]
        public void Puzzle1Example_FindsCorrectCompleteOrder()
        {
            var set = new StepSet(Input.Day07Parse(PuzzleExample));

            var order = set.OrderOfComplete();

            order.Should().Be("CABDFE");
        }

        [Fact]
        public void Puzzle1Example_StepSet_ParsesStepsAndDependenciesCorrectly()
        {
            var set = new StepSet(Input.Day07Parse(PuzzleExample));

            set.Steps.Should().HaveCount(6).And.ContainKeys('C', 'A', 'F', 'B', 'D', 'E');
            set.Steps['C'].Dependencies.Should().BeEmpty();
            set.Steps['C'].CanComplete.Should().BeTrue();
            set.Steps['A'].Dependencies.Should().OnlyContain(x => x.Id == 'C');
            set.Steps['F'].Dependencies.Should().OnlyContain(x => x.Id == 'C');
            set.Steps['B'].Dependencies.Should().OnlyContain(x => x.Id == 'A');
            set.Steps['D'].Dependencies.Should().OnlyContain(x => x.Id == 'A');
            set.Steps['E'].Dependencies.Should().HaveCount(3).And.OnlyContain(x => x.Id == 'B' || x.Id == 'D' || x.Id == 'F');
        }
    }
}