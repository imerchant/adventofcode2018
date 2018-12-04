using System.IO;
using System.Linq;
using AdventOfCode2018.Day04;
using AdventOfCode2018.Inputs;
using FluentAssertions;
using Xunit;
using Xunit.Abstractions;

namespace AdventOfCode2018.Tests.Solutions
{
    public class Day04Solutions : TestBase
    {
        public Day04Solutions(ITestOutputHelper output) : base(output)
        {
        }

        [Fact]
        public void Puzzle1_FindGuardAsleepTheMost_AndMinuteMostAsleep()
        {
            var log = new GuardLog(Input.Day04Parse(Input.Day04));

            var (guard, minute) = log.Strategy1();

            (guard * minute).Should().Be(14346);
        }

        [Fact]
        public void Puzzle2_FindGuardAsleepTheSameMinuteTheMost()
        {
            var log = new GuardLog(Input.Day04Parse(Input.Day04));

            var (guard, minute, _) = log.Strategy2();

            (guard * minute).Should().Be(5705);
        }

        public const string PuzzleExample =
@"[1518-11-01 00:00] Guard #10 begins shift
[1518-11-01 00:05] falls asleep
[1518-11-01 00:25] wakes up
[1518-11-01 00:30] falls asleep
[1518-11-01 00:55] wakes up
[1518-11-01 23:58] Guard #99 begins shift
[1518-11-02 00:40] falls asleep
[1518-11-02 00:50] wakes up
[1518-11-03 00:05] Guard #10 begins shift
[1518-11-03 00:24] falls asleep
[1518-11-03 00:29] wakes up
[1518-11-04 00:02] Guard #99 begins shift
[1518-11-04 00:36] falls asleep
[1518-11-04 00:46] wakes up
[1518-11-05 00:03] Guard #99 begins shift
[1518-11-05 00:45] falls asleep
[1518-11-05 00:55] wakes up";

        [Fact]
        public void Puzzle1Example_LocateGuardWhosAsleepMostMinutesCorrectly()
        {
            var input = Input.Day04Parse(PuzzleExample);
            var log = new GuardLog(input);

            var (guard, minute) = log.Strategy1();

            guard.Should().Be(10);
            minute.Should().Be(24);
        }

        [Fact]
        public void Puzzle2Example_LocateGuardWhoSleptTheMostDuringTheSameMinute()
        {
            var input = Input.Day04Parse(PuzzleExample);
            var log = new GuardLog(input);

            var (guard, minute, _) = log.Strategy2();

            guard.Should().Be(99);
            minute.Should().Be(45);
        }

        [Fact]
        public void InputParse_OrdersInputCorrectly()
        {
            var input = Input.Day04Parse(Input.Day04);

            var selection = input.Take(10).ToList();

            foreach (var line in selection)
            {
                Output.WriteLine(line);
            }

            // File.AppendAllLines("C:/projects/adventofcode/2018/day04input.txt", input);
        }

        [Fact]
        public void UnaryIncrement_OnDictionaryValue_Works()
        {
            var dict = new DefaultDictionary<int, int>(_ => 0);

            dict[0]++;

            dict[0].Should().Be(1);
        }
    }
}