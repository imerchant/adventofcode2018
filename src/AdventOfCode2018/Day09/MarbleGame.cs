using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventOfCode2018.Day09
{
    public class MarbleGame
    {
        private const int MutatedOperationValueFactor = 23;
        private readonly int _maxMarbleValue;
        private readonly Marble Zero;
        private uint _currentMarbleValue;

        public Marble Current { get; private set; }
        public IList<Player> Players { get; }

        public MarbleGame(int players, int maxMarbleValue)
        {
            Players = Enumerable.Range(0, players).Select(x => new Player(x + 1)).ToList();
            _maxMarbleValue = maxMarbleValue;
            _currentMarbleValue = 0;

            var zero = new Marble(0);
            zero.Previous = zero;
            zero.Next = zero;
            Zero = zero;
            Current = zero;
        }

        public void Play()
        {
            var currentPlayerIndex = 0;
            do
            {
                Play(Players[currentPlayerIndex++ % Players.Count]);
            }
            while (_currentMarbleValue < _maxMarbleValue);
        }

        internal void Play(Player player)
        {
            _currentMarbleValue++;
            if (_currentMarbleValue % MutatedOperationValueFactor == 0)
            {
                // do special thing
                player.Score += _currentMarbleValue;
                var sevenBack = Current.Previous.Previous.Previous.Previous.Previous.Previous.Previous;

                var eightBack = sevenBack.Previous;
                var sixBack = sevenBack.Next;
                eightBack.Next = sixBack;
                sixBack.Previous = eightBack;
                sevenBack.Removed = true;

                player.Score += sevenBack.Value;

                Current = sixBack;
            }
            else
            {
                var oneStep = Current.Next;
                var twoStep = Current.Next.Next;

                var newMarble = new Marble(_currentMarbleValue);
                newMarble.Previous = oneStep;
                oneStep.Next = newMarble;

                newMarble.Next = twoStep;
                twoStep.Previous = newMarble;

                Current = newMarble;
            }
        }

        public override string ToString()
        {
            if (Zero.Removed)
                return $"Zero node was removed, current node has value {Current.Value}";

            var builder = new StringBuilder();
            var current = Zero;
            do
            {
                var isCurrent = current.Value == Current.Value;
                builder.Append(' ').Append(current.Value);
                if (isCurrent)
                    builder.Append('*');
                builder.Append(' ');

                current = current.Next;
            }
            while (current.Value != 0);
            return builder.ToString();
        }
    }
}