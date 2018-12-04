using System;
using System.Collections.Generic;

namespace AdventOfCode2018.Day04
{
    public class Night
    {
        public int Month { get; }
        public int Day { get; }
        public int Guard { get; }

        public ISet<int> Asleep { get; }

        public Night(int month, int day, int guard)
        {
            Month = month;
            Day = day;
            Guard = guard;
            Asleep = new HashSet<int>();
        }

        public void RecordSleep(int fallsAsleep, int wakesUp)
        {
            if (fallsAsleep > wakesUp)
                throw new Exception("fell asleep after woke up");

            for (var k = fallsAsleep; k < wakesUp; ++k)
            {
                Asleep.Add(k);
            }
        }
    }
}