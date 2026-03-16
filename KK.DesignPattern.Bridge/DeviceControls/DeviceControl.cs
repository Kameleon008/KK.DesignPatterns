using KK.DesignPattern.Bridge.Devices;

namespace KK.DesignPattern.Bridge.DeviceControls
{
    internal abstract class DeviceControl(IDevice device)
    {
        protected IDevice Device { get; } = device;

        public void TogglePower()
        {
            if (this.Device.IsEnabled)
            {
                this.Device.Disable();
            }

            else
            {
                this.Device.Enable();
            }
        }

        public void VolumeUp()
        {
            var volume = this.Device.GetVolume();
            this.Device.SetVolume(volume + 5);
        }

        public void VolumeDown()
        {
            var volume = this.Device.GetVolume();
            this.Device.SetVolume(volume - 5);
        }

        public void ChannelUp()
        {
            var channel = this.Device.GetChannel();
            this.Device.SetChannel(channel + 1);
        }

        public void ChannelDown()
        {
            var channel = this.Device.GetChannel();
            this.Device.SetChannel(channel - 1);
        }
    }
}
