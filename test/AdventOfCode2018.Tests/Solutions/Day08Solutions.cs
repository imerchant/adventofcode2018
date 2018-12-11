using System.Collections.Generic;
using System.Linq;
using AdventOfCode2018.Day08;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day08Solutions : TestBase
    {
        public Day08Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle_FindLicenseChecksum_AndRootValue()
        {
            var input = Input.Day08Parse(Input.Day08);

            var license = new License(input);

            license.Checksum.Should().Be(35911);
            license.Root.Value.Should().Be(17206);
        }

        const string PuzzleExample = "2 3 0 3 10 11 12 1 1 0 1 99 2 1 1 2";

        [Fact]
        public void PuzzleExample_ParsesNodesCorrectly()
        {
            var input = Input.Day08Parse(PuzzleExample);

            var license = new License(input);

            license.Root.Children.Should().HaveCount(2).And.OnlyContain(x => x.Id == 'B' || x.Id == 'C');
            license.Root.Metadata.Should().BeEquivalentTo(new [] { 1, 1, 2 });
            license.Root.Value.Should().Be(66);

            var b = license.Root.Children.First();
            b.Children.Should().BeEmpty();
            b.Metadata.Should().BeEquivalentTo(new [] { 10, 11, 12 });
            b.Value.Should().Be(33);

            var c = license.Root.Children.Skip(1).First();
            c.Children.Should().HaveCount(1).And.OnlyContain(x => x.Id == 'D');
            c.Metadata.Should().BeEquivalentTo(new [] { 2 });
            c.Value.Should().Be(0);

            var d = c.Children.First();
            d.Children.Should().BeEmpty();
            d.Metadata.Should().BeEquivalentTo(new [] { 99 });
            d.Value.Should().Be(99);

            license.Checksum.Should().Be(138);
        }

        [Fact]
        public void License_CanParse_AAndBNodes()
        {
            var input = new List<int> { 1, 3, 0, 1, 99, 1, 1, 1 };

            var license = new License(input);

            license.Checksum.Should().Be(99 + 1 + 1 + 1);
            license.Root.Children.Should().HaveCount(1);
            var b = license.Root.Children.First();
            b.Id.Should().Be('B');
            b.Metadata.Should().ContainSingle().And.OnlyContain(x => x == 99);
        }

        [Fact]
        public void License_CanParse_OnlyANode()
        {
            var input = new List<int> { 0, 3, 1, 1, 1 };

            var license = new License(input);

            license.Root.Children.Should().BeEmpty();
            license.Root.Checksum.Should().Be(3);
            license.Root.Metadata.Should().HaveCount(3).And.OnlyContain(x => x == 1);
            license.Checksum.Should().Be(3);
        }
    }
}