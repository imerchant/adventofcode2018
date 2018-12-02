using System;
using System.Collections.Generic;
using System.Linq;
using AdventOfCode2018.Day02;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day02Solutions : TestBase
    {
        public Day02Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle1_FindChecksum()
        {
            var ids = Input.Day02Parse(Input.Day02).Select(x => new BoxId(x));
            var twos = ids.Count(x => x.TwoMatch);
            var threes = ids.Count(x => x.ThreeMatch);

            var checksum = twos * threes;

            checksum.Should().Be(5952);
        }

        [Fact]
        public void Puzzle2_FindCommonLetters()
        {
            var ids = Input.Day02Parse(Input.Day02).Select(x => new BoxId(x)).ToList();

            var common = BoxId.FindCommonLetters(ids);

            common.Should().Be("krdmtuqjgwfoevnaboxglzjph");
        }

        [Theory]
        [InlineData("abcdef", false, false)]
        [InlineData("bababc", true, true)]
        [InlineData("abbcde", true, false)]
        [InlineData("abcccd", false, true)]
        [InlineData("aabcdd", true, false)]
        [InlineData("abcdee", true, false)]
        [InlineData("ababab", false, true)]
        public void BoxId_CountsMatchesCorrectly(string input, bool twoMatch, bool threeMatch)
        {
            var boxId = new BoxId(input);

            boxId.TwoMatch.Should().Be(twoMatch);
            boxId.ThreeMatch.Should().Be(threeMatch);
        }

        public const string Puzzle1Example =
@"abcdef
bababc
abbcde
abcccd
aabcdd
abcdee
ababab";

        [Fact]
        public void FindChecksum_Correctly()
        {
            var ids = Input.Day02Parse(Puzzle1Example).Select(x => new BoxId(x));
            var twos = ids.Count(x => x.TwoMatch);
            var threes = ids.Count(x => x.ThreeMatch);

            var checksum = twos * threes;

            checksum.Should().Be(12);
        }

        public const string Puzzle2Example =
@"abcde
fghij
klmno
pqrst
fguij
axcye
wvxyz";

        [Fact]
        public void FindCommonLetters()
        {
            var ids = Input.Day02Parse(Puzzle2Example).Select(x => new BoxId(x)).ToList();

            var common = BoxId.FindCommonLetters(ids);

            common.Should().Be("fgij");
        }
    }
}