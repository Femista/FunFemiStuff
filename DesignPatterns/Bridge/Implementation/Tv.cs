namespace Bridge.Implementation
{
    public class Tv : IDevice
    {
        private int _channel;
        private int _volume;

        public bool IsEnabled { get; set; }

        public void Enable()
        {
            IsEnabled = true;
        }

        public void Disable()
        {
            IsEnabled = false;
        }

        public int GetVolume()
        {
            return _volume;
        }

        public void SetVolume(int volume)
        {
            _volume = volume;
        }

        public int GetChannel()
        {
            return _channel;
        }

        public void SetChannel(int channel)
        {
            _channel = channel;
        }
    }
}