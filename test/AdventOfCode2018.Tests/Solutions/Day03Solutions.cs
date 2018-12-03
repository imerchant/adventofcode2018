using AdventOfCode2018.Day03;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day03Solutions : TestBase
    {
        public Day03Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle1_CountCollisionsInFabric()
        {
            var input = Input.Day03Parse(Input.Day03);
            var fabric = new Fabric(input);

            var collisions = fabric.FindCollisions();

            collisions.Should().HaveCount(111935);
        }

        [Fact]
        public void Puzzle2_FindUncollidedPiece()
        {
            var input = Input.Day03Parse(Input.Day03);
            var fabric = new Fabric(input);

            var collisions = fabric.FindUncollidedPiece();

            collisions.Should().Be(650);
        }

        public const string PuzzleExample =
@"#1 @ 1,3: 4x4
#2 @ 3,1: 4x4
#3 @ 5,5: 2x2";

        [Fact]
        public void Puzzle1Example_FindsCorrectCountOfCollisions()
        {
            var input = Input.Day03Parse(PuzzleExample);
            var fabric = new Fabric(input);

            var collisions = fabric.FindCollisions();

            collisions.Should().HaveCount(4);
        }

        [Fact]
        public void Puzzle2Example_FindsCorrectUncollidedPiece()
        {
            var input = Input.Day03Parse(PuzzleExample);
            var fabric = new Fabric(input);

            var collisions = fabric.FindUncollidedPiece();

            collisions.Should().Be(3);
        }
    }
}