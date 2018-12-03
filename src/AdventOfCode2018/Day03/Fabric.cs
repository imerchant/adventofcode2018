using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode2018.Day03
{
    public class Fabric
    {
        public IList<Square> Squares { get; }

        public Fabric(IList<string> input)
        {
            Squares = input.Select(Square.Parse).ToList();
        }

        public ISet<(int X, int Y)> FindCollisions()
        {
            var fabric = new HashSet<(int X, int Y)>();
            var collisions  = new HashSet<(int X, int Y)>();

            foreach (var location in Squares.SelectMany(x => x.Area))
            {
                if (!fabric.Add(location))
                    collisions.Add(location);
            }

            return collisions;
        }

        public int FindUncollidedPiece()
        {
            var fabric = new DefaultDictionary<(int X, int Y), ISet<int>>(_ => new SortedSet<int>());

            foreach (var square in Squares)
            {
                foreach (var location in square.Area)
                {
                    fabric[location].Add(square.Id);
                }
            }

            var squares = Squares.Select(x => x.Id).ToHashSet();
            squares.ExceptWith(fabric.Values.Where(x => x.Count > 1).SelectMany(x => x));
            return squares.Single();
        }
    }
}