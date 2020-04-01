namespace Bridge.Implementation
{
    public interface IDevice
    {
        bool IsEnabled { get; set; }
        void Enable();
        void Disable();
        int GetVolume();
        void SetVolume(int volume);
        int GetChannel();
        void SetChannel(int channel);
    }
}