using System.IO;
using AdventOfCode2018.Day11;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day11Solutions : TestBase
    {
        public Day11Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle1_FindHighestPower3x3()
        {
            var grid = new PowerGrid(Input.Day11);

            var (x, y, _) = grid.FindHighestPower3x3();

            (x, y).Should().Be((235,38));

            // var sums = grid.GetSumTable();
            // File.WriteAllText(@"C:\projects\adventofcode\2018\sumtable.txt", sums);
            // var sums = grid.GetPowers();
            // File.WriteAllText(@"C:\projects\adventofcode\2018\power.txt", sums);
        }

        [Theory]
        [InlineData(8, 3, 5, 4)]
        [InlineData(57, 122, 79, -5)]
        [InlineData(39, 217, 196, 0)]
        [InlineData(71, 101, 153, 4)]
        public void Puzzle1Example_CalculatesPowerLevelCorrectly(int serialNumber, int x, int y, long expectedPower)
        {
            var grid = new PowerGrid(serialNumber);

            grid[(x, y)].Should().Be(expectedPower);
        }

        [Theory]
        [InlineData(123, 1)]
        [InlineData(232, 2)]
        [InlineData(456, 4)]
        [InlineData(1156, 1)]
        [InlineData(46, 0)]
        [InlineData(1, 0)]
        [InlineData(10_908, 9)]
        public void FindHundredsDigit(int value, int expectedDigit)
        {
            var digit = (value / 100) % 10;

            digit.Should().Be(expectedDigit);
        }
    }
}