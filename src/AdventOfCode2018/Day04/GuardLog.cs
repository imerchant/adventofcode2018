using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using MoreLinq;

namespace AdventOfCode2018.Day04
{
    public class GuardLog
    {
        private static readonly Regex NightStartRegex = new Regex(@"\[1518-(?'month'\d{2})-(?'day'\d{2}) (?'hour'\d{2}):(?'minute'\d{2})\] Guard #(?'guardId'\d+?) begins", RegexOptions.Compiled);
        private static readonly Regex GetTimeRegex = new Regex(@"\[1518-(?'month'\d{2})-(?'day'\d{2}) (?'hour'\d{2}):(?'minute'\d{2})\]", RegexOptions.Compiled);

        public IList<Night> Nights { get; }

        public GuardLog(IList<string> input)
        {
            Nights = new List<Night>(input.Count / 3);

            LoadNights(input);
        }

        private void LoadNights(IList<string> input)
        {
            Night currentNight = null;
            int? lastFallAsleep = null;

            foreach (var line in input)
            {
                if (line.Contains("begins shift"))
                {
                    var (month, day, guard) = GetNightStartInfo(line);
                    currentNight = new Night(month, day, guard);
                    Nights.Add(currentNight);
                }
                else if (line.Contains("falls"))
                {
                    lastFallAsleep = GetMinute(line);
                }
                else if (line.Contains("wakes"))
                {
                    var wake = GetMinute(line);
                    currentNight.RecordSleep(lastFallAsleep.Value, wake);
                    lastFallAsleep = null;
                }
            }

            (int month, int day, int guard) GetNightStartInfo(string line)
            {
                var match = NightStartRegex.Match(line);
                if (!match.Success)
                    throw new Exception($"could not parse \"{line}\" as night start line");

                var month = int.Parse(match.Groups["month"].Value);
                var day = int.Parse(match.Groups["day"].Value);
                var hour = int.Parse(match.Groups["hour"].Value);
                var guard = int.Parse(match.Groups["guardId"].Value);

                if (hour != 0)
                    day++;

                return (month, day, guard);
            }

            int GetMinute(string line)
            {
                var match = GetTimeRegex.Match(line);
                if (!match.Success)
                    throw new Exception($"could not find time in \"{line}\"");

                return int.Parse(match.Groups["minute"].Value);
            }
        }

        public (int Guard, int MinuteMostAsleep) Strategy1()
        {
            var byGuard = Nights
                .GroupBy(night => night.Guard)
                .OrderByDescending(grouping => grouping.SelectMany(x => x.Asleep).Count())
                .ThenBy(grouping => grouping.Key);

            var nights = byGuard.First();

            var mostAsleepGuard = nights.Key;
            var (maxMinute, _) = FindMinuteMostAsleep(nights);

            return (mostAsleepGuard, maxMinute);
        }

        public (int Guard, int Minute, int Count) Strategy2()
        {
            var data = Nights
                .GroupBy(night => night.Guard)
                .Select(grouping =>
                {
                    var (minute, count) = FindMinuteMostAsleep(grouping);
                    return (grouping.Key, minute, count);
                })
                .OrderByDescending(tuple => tuple.count);

            return data.First();
        }

        private (int Minute, int Count) FindMinuteMostAsleep(IGrouping<int, Night> nights)
        {
            var minutesAsleep = new DefaultDictionary<int, int>(60, _ => 0);
            foreach (var minute in nights.SelectMany(night => night.Asleep))
            {
                minutesAsleep[minute]++;
            }

            if (!minutesAsleep.Any())
                return (0, 0);

            var maxMinute = minutesAsleep.MaxBy(x => x.Value).First();

            return (maxMinute.Key, maxMinute.Value);
        }
    }
}