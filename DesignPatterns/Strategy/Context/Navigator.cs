using Strategy.Strategy;

namespace Strategy.Context
{
    public class Navigator
    {
        private IStrategy _strategy;

        public void SetStrategy(IStrategy strategy)
        {
            _strategy = strategy;
        }

        public string GetArrivalTime(string place, int distance)
        {
            return $"It will take {_strategy.GetArrivalTime(distance)} minutes to get to {place}";
        }

    }
}