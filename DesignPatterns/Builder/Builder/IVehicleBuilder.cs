namespace Builder.Builder
{
    public interface IVehicleBuilder
    {
        void Reset();
        void SetSeats(int seatNumber);
        void SetEngine(string engineType);
        void SetColor(string color);
        void SetInfo(string name);
    }
}