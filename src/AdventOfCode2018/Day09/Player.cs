namespace AdventOfCode2018.Day09
{
    public class Player
    {
        public int Id { get; }
        public ulong Score { get; set; }

        public Player(int id)
        {
            Id = id;
        }
    }
}