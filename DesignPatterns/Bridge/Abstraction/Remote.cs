using Bridge.Implementation;

namespace Bridge.Abstraction
{
    public class Remote
    {
        protected readonly IDevice _device;

        public Remote(IDevice device)
        {
            _device = device;
        }

        public void TogglePower()
        {
            if (_device.IsEnabled)
            {
                _device.Enable();
            }
            else
            {
                _device.Disable();
            }
        }

        public void VolumeUp()
        {
            _device.SetVolume(_device.GetVolume()+1);
        }

        public void VolumeDown()
        {
            _device.SetVolume(_device.GetVolume()-1);
        }

        public void ChannelUp()
        {
            _device.SetChannel(_device.GetChannel()+1);
        }

        public void ChannelDown()
        {
            _device.SetChannel(_device.GetChannel()-1);
        }
    }
}