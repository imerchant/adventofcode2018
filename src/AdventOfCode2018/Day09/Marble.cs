namespace AdventOfCode2018.Day09
{
    public class Marble
    {
        public uint Value { get; }
        public Marble Previous { get; set; }
        public Marble Next { get; set; }
        public bool Removed { get; set; }

        public Marble(uint value)
        {
            Value = value;
        }
    }
}