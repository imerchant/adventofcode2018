using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day07
{
    public class Step : IEquatable<Step>
    {
        public char Id { get; }
        public ISet<Step> Dependencies { get; }
        public bool CanComplete => !IsComplete && (!Dependencies.HasAny() || Dependencies.All(x => x.IsComplete));
        public bool IsComplete { get; set; }

        public Step(char id)
        {
            Id = id;
            Dependencies = new HashSet<Step>();
            IsComplete = false;
        }

        public override bool Equals(object obj)
        {
            if (ReferenceEquals(null, obj)) return false;
            if (ReferenceEquals(this, obj)) return true;
            return obj is Step step
                ? Equals(step)
                : false;
        }

        public bool Equals(Step other)
        {
            return Id == other?.Id;
        }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }
    }
}