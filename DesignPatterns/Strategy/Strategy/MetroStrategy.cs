namespace Strategy.Strategy
{
    public class MetroStrategy : IStrategy
    {
        public int GetArrivalTime(int distance)
        {
            return distance * 10;
        }
    }
}