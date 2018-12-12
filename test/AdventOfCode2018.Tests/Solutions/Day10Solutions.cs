using System.Linq;
using AdventOfCode2018.Day10;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day10Solutions : TestBase
    {
        public Day10Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle1_After10345Iterations_PrintGrid()
        {
            var lights = new LightGrid(Input.Day10Parse(Input.Day10));

            lights.Tick(10345); // answer to puzzle 2

            Output.WriteLine($"{lights}");

            // prints out CPJRNKCF
        }

        [Fact]
        public void Puzzle1_FindLowestArea()
        {
            // all thanks to https://www.reddit.com/r/adventofcode/comments/a4skra/2018_day_10_solutions/ebhafz0/

            var lights = new LightGrid(Input.Day10Parse(Input.Day10));

            var iterations = Enumerable.Range(0, 20_000).ToList();

            var iterationAreaMap = iterations.ToDictionary(iteration => iteration,
            iteration =>
            {
                var positions = lights.Lights.Select(light => light.PositionAfter(iteration)).ToList();

                var minX = positions.Min(x => x.X);
                var maxX = positions.Max(x => x.X);
                var minY = positions.Min(x => x.Y);
                var maxY = positions.Max(x => x.Y);

                return maxX - minY + maxY - minY;
            });

            var lowestArea = iterationAreaMap.OrderBy(x => x.Value).First();

            Output.WriteLine($"{lowestArea.Key}: {lowestArea.Value}");
        }

        [Theory]
        [InlineData("position=< 9,  1> velocity=< 0,  2>",  9,  1,  0,  2)]
        [InlineData("position=< 7,  0> velocity=<-1,  0>",  7,  0, -1,  0)]
        [InlineData("position=< 3, -2> velocity=<-1,  1>",  3, -2, -1,  1)]
        [InlineData("position=< 6, 10> velocity=<-2, -1>",  6, 10, -2, -1)]
        [InlineData("position=< 2, -4> velocity=< 2,  2>",  2, -4,  2,  2)]
        [InlineData("position=<-6, 10> velocity=< 2, -2>", -6, 10,  2, -2)]
        public void Light_ParsesCorrectly(string input, int posX, int posY, int velX, int velY)
        {
            var light = Light.Parse(input, 0);

            light.X.Should().Be(posX);
            light.Y.Should().Be(posY);
            light.Velocity.Should().Be((velX, velY));
        }
    }
}