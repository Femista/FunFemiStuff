using Builder.Product;

namespace Builder.Builder
{
    public class TonkaTruckManualBuilder : IVehicleBuilder
    {
        private CarManual _carManual;

        public void Reset()
        {
            _carManual = new CarManual();
        }

        public void SetSeats(int seatNumber)
        {
            _carManual.Seats = seatNumber;
        }

        public void SetEngine(string engineType)
        {
            _carManual.Engine = engineType;
        }

        public void SetColor(string color)
        {
            _carManual.Color = color;
        }

        public void SetInfo(string name)
        {
            _carManual.Info = $"I am a manual for a {_carManual.Color} car created by {name} with {_carManual.Seats} seats.";
        }

        public CarManual GetResult()
        {
            return _carManual;
        }
    }
}