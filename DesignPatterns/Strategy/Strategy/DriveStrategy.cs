namespace Strategy.Strategy
{
    public class DriveStrategy : IStrategy
    {
        public int GetArrivalTime(int distance)
        {
            return distance * 5;
        }
    }
}