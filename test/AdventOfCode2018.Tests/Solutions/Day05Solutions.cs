using AdventOfCode2018.Day05;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day05Solutions : TestBase
    {
        public Day05Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact(Skip = "takes a while")]
        public void Puzzle1_CountRemainingUnits_AfterAllCollapseEvents()
        {
            var polymer = new Polymer(Input.Day05);

            var collapsed = polymer.Collapse();

            collapsed.Should().HaveLength(9288);
        }

        [Fact(Skip = "takes a while")]
        public void Puzzle2_ReduceUnits_AndFindShortestChain()
        {
            var polymer = new Polymer(Input.Day05);

            var shortest = polymer.FindShortestPolymer();

            shortest.Should().HaveLength(5844);
        }

        [Fact]
        public void Puzzle1LargerExample_PolymerCollapsesCorrectly()
        {
            const string input = "dabAcCaCBAcCcaDA";
            const string expected = "dabCBAcaDA";
            var polymer = new Polymer(input);

            var collapsed = polymer.Collapse();

            collapsed.Should().Be(expected);
        }

        [Fact]
        public void Puzzle2Example_PolymerReducesUnitsAndFindsShortestPossibleChain()
        {
            const string input = "dabAcCaCBAcCcaDA";
            const string expected = "daDA";

            var actual = new Polymer(input).FindShortestPolymer();

            actual.Should().Be(expected);
        }

        [Theory]
        [InlineData('a', 'A', true)]
        [InlineData('a', 'a', false)]
        [InlineData('A', 'a', true)]
        [InlineData('A', 'A', false)]
        [InlineData('b', 'A', false)]
        [InlineData('b', 'a', false)]
        [InlineData('B', 'a', false)]
        [InlineData('B', 'b', true)]
        [InlineData('C', 'c', true)]
        public void Polymer_UnitsReact_DetectsWhetherUnitsReactCorrectly(char one, char two, bool expectedReaction)
        {
            Polymer.UnitsReact(one, two).Should().Be(expectedReaction);
        }
    }
}