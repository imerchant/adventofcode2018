namespace AdventOfCode2018.Day07
{
    public class Worker
    {
        private readonly int _operationCost;
        private int _progress;

        public int Id { get; }
        public Step WorkingOn { get; private set; }
        public int Count { get; }
        public bool IsIdle => WorkingOn == null;
        public bool IsDone => !IsIdle && _progress == _operationCost + WorkingOn.Cost;

        public Worker(int id, int operationCost)
        {
            Id = id;
            _operationCost = operationCost;
        }

        public void WorkOn(Step step)
        {
            WorkingOn = step;
            step.IsBeingWorkedOn = true;
            _progress = 0;
        }

        public void Tick()
        {
            if (!IsIdle)
                _progress++;
        }

        public void Reset()
        {
            WorkingOn = null;
        }
    }
}