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

        public const string Puzzle1Example =
@"Step C must be finished before step A can begin.
Step C must be finished before step F can begin.
Step A must be finished before step B can begin.
Step A must be finished before step D can begin.
Step B must be finished before step E can begin.
Step D must be finished before step E can begin.
Step F must be finished before step E can begin.";

        [Fact]
        public void Puzzle1Example_FindsCorrectCompleteOrder()
        {
            var set = new StepSet(Input.Day07Parse(Puzzle1Example));

            var order = set.OrderOfComplete();

            order.Should().Be("CABDFE");
        }

        [Fact]
        public void Puzzle1Example_StepSet_ParsesStepsAndDependenciesCorrectly()
        {
            var set = new StepSet(Input.Day07Parse(Puzzle1Example));

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