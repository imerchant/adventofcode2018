using System.Linq;
using AdventOfCode2018.Day09;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using MoreLinq;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day09Solutions : TestBase
    {
        public Day09Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle1_FindMaxScore()
        {
            var game = new MarbleGame(Input.Day09.Players, Input.Day09.LastMarble);

            game.Play();

            game.Players.Max(x => x.Score).Should().Be(404502);
        }

        [Fact]
        public void Puzzle2_FindMaxScoreWith100xTheMaxMarbleValue()
        {
            var game = new MarbleGame(Input.Day09.Players, Input.Day09.LastMarble * 100);

            game.Play();

            game.Players.Max(x => x.Score).Should().Be(3243916887);
        }

        [Theory]
        [InlineData(7, 25, 32)]
        [InlineData(10, 1618, 8317)]
        [InlineData(13, 7999, 146373)]
        [InlineData(17, 1104, 2764)]
        [InlineData(21, 6111, 54718)]
        [InlineData(30, 5807, 37305)]
        public void Puzzle1Examples_FindsCorrectMaxScore(int playerCount, int maxMarbleValue, ulong expectedMaxScore)
        {
            var game = new MarbleGame(playerCount, maxMarbleValue);

            game.Play();

            game.Players.Max(x => x.Score).Should().Be(expectedMaxScore);
        }

        [Fact]
        public void Puzzle1Example_FindsCorrectPlayerAndTopScore()
        {
            const int players = 9;
            const int maxMarbleValue = 25;
            var game = new MarbleGame(players, maxMarbleValue);

            game.Play();

            game.Current.Value.Should().Be(25);
            var maxPlayer = game.Players.MaxBy(x => x.Score).Single();
            maxPlayer.Id.Should().Be(5);
            maxPlayer.Score.Should().Be(32);
        }

        [Fact]
        public void Puzzle1Example_StepsCorrectly()
        {
            const int players = 9;
            const int maxMarbleValue = 25;
            var game = new MarbleGame(players, maxMarbleValue);
            game.Players.Should().HaveCount(9).And.BeInAscendingOrder(x => x.Id);
            game.Players.First().Id.Should().Be(1);

            Output.WriteLine($"\n[-] {game}");
            foreach (var player in game.Players)
            {
                game.Play(player);
                Output.WriteLine($"[{player.Id}] {game}");
            }

            game.Current.Value.Should().Be(9);

        }
    }
}