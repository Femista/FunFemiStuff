namespace Strategy.Strategy
{
    public class WalkStrategy : IStrategy
    {
        public int GetArrivalTime(int distance)
        {
            return distance * 30;
        }
    }
}