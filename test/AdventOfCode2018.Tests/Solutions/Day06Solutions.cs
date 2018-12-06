using System.Collections.Generic;
using System.IO;
using System.Linq;
using AdventOfCode2018.Day06;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day06Solutions : TestBase
    {
        public Day06Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle1_FindLargestNonInfiniteGroup()
        {
            var grid = new RegionsGroupedByCoordinate(Input.Day06Parse(Input.Day06));

            var sizes = grid.Coordinates.Select(x => grid.SizeOf(x)).OrderByDescending(x => x).ToList();

            sizes.Should().StartWith(3604);
        }

        [Fact]
        public void Puzzle2_FindSizeOfRegion_BySummingDistancesToCoordinates()
        {
            var grid = new RegionByDistanceToAllCoordinates(Input.Day06Parse(Input.Day06));

            grid.SizeOfRegion.Should().Be(46563);
        }

        [Fact]
        public void RegionByDistanceSum_MapsCorrectly()
        {
            var grid = new RegionByDistanceToAllCoordinates(Input.Day06Parse(PuzzleExample), 32);

            Output.WriteLine(grid.ToString());
            grid.SizeOfRegion.Should().Be(16);
        }

        [Fact]
        public void Grid_WithRealInput_ToString()
        {
            var grid = new RegionsGroupedByCoordinate(Input.Day06Parse(Input.Day06));

            var asString = grid.ToString();

            //File.AppendAllText(@"C:\Projects\adventofcode\2018\day06output.txt", asString);
        }

        public const string PuzzleExample =
@"1, 1
1, 6
8, 3
3, 4
5, 5
8, 9";

        [Fact]
        public void Puzzle1Example_FindsLargestNonInfiniteGroup()
        {
            var grid = new RegionsGroupedByCoordinate(Input.Day06Parse(PuzzleExample));

            var sizes = grid.Coordinates.Select(x => grid.SizeOf(x)).OrderByDescending(x => x).ToList();

            sizes.Should().StartWith(17);
        }

        [Fact]
        public void Puzzle1Example_GridPopulatesCorrectly()
        {
            var expectedOutside = new List<int> { -1, 0 , 1, 2, 5 };
            var grid = new RegionsGroupedByCoordinate(Input.Day06Parse(PuzzleExample));

            Output.WriteLine(grid.ToString());
            grid.Outside.Should().OnlyContain(x => expectedOutside.Contains(x));
        }
    }
}