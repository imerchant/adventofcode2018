using System.Collections.Generic;

namespace AdventOfCode2018.Day08
{
    public class License
    {
        private readonly IList<int> _input;
        private char _currentId = 'A';

        public Node Root { get; }
        public int Checksum => Root.Checksum;

        public License(IList<int> input)
        {
            _input = input;
            Root = new Node('A');
            ParseNode(0, null);
        }

        private int ParseNode(int index, Node parent)
        {
            Node thisNode;
            if (index == 0)
            {
                thisNode = Root;
            }
            else
            {
                var id = ++_currentId;
                thisNode = new Node(id);
                parent.Children.Add(thisNode);
            }

            var myChildren = _input[index++];
            var myMetadata = _input[index++];

            for (var k = 0; k < myChildren; ++k)
            {
                index = ParseNode(index, thisNode);
            }

            if (myMetadata == 0)
            {
                index++;
            }
            else
            {
                for (var k = 0; k < myMetadata; ++k)
                {
                    thisNode.Metadata.Add(_input[index++]);
                }
            }

            return index;
        }
    }
}