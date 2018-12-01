using AdventOfCode2018.Day01;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day01Solutions : TestBase
    {
        public Day01Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle1_SumFrequencyMutations()
        {
            var counter = new FrequencyCounter(Input.Day01Parse(Input.Day01));

            counter.Sum.Should().Be(472);
        }

        [Fact]
        public void Puzzle2_FindFirstDuplicateFrequency()
        {
            var counter = new FrequencyCounter(Input.Day01Parse(Input.Day01));

            var firstDuplicate = counter.FindFirstDuplicate();

            firstDuplicate.Should().Be(66932);
        }

        [Theory]
        [InlineData("+1", 1)]
        [InlineData("-1", -1)]
        [InlineData("-2", -2)]
        [InlineData("-133358", -133358)]
        public void Mutation_ParseNegativesCorrectly(string input, int expectedValue)
        {
            var freq = Mutation.Parse(input);

            freq.Value.Should().Be(expectedValue);
        }

        [Theory]
        [InlineData("+1\n-1", 0)]
        [InlineData("+3\n+3\n+4\n-2\n-4", 10)]
        [InlineData("-6\n+3\n+8\n+5\n-6", 5)]
        [InlineData("+7\n+7\n-2\n-7\n-4", 14)]
        public void FrequencyCounter_LocatesFirstDuplicateCorrectly(string input, int expectedValue)
        {
            var mutations = Input.Day01Parse(input);
            var counter = new FrequencyCounter(mutations);

            var firstDuplicate = counter.FindFirstDuplicate();

            firstDuplicate.Should().Be(expectedValue);
        }
    }
}