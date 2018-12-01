namespace AdventOfCode2018.Day01
{
    public class Mutation
    {
        public int Value { get; }

        private Mutation(int value)
        {
            Value = value;
        }

        public static Mutation Parse(string input)
        {
            return new Mutation(int.Parse(input));
        }
    }
}