using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day08
{
    public class Node
    {
        public char Id { get; }
        public IList<Node> Children { get; }
        public IList<int> Metadata { get; }
        public int Checksum => Metadata.Sum() + Children.Sum(x => x.Checksum);
        public int Value => GetValue();

        public Node(char id)
        {
            Id = id;
            Children = new List<Node>();
            Metadata = new List<int>();
        }

        private int GetValue()
        {
            if (!Children.Any())
                return Metadata.Sum();

            return Metadata
                .Where(x => x <= Children.Count)
                .Sum(x => Children[x - 1].Value);
        }
    }
}