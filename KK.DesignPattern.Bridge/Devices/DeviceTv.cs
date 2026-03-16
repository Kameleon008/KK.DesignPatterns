using KK.DesignPattern.Bridge.Exceptions;

namespace KK.DesignPattern.Bridge.Devices
{
    internal class DeviceTv : IDevice
    {
        public bool IsEnabled { get; private set; } = false;

        public int Volume { get; private set; } = 0;

        public int Channel { get; private set; } = 0;

        public void Enable()
        {
            this.IsEnabled = true;
        }

        public void Disable()
        {
            this.IsEnabled = false;
        }

        public int GetVolume()
        {
            CheckIsEnabled();
            return this.Volume;
        }

        public void SetVolume(int percent)
        {
            CheckIsEnabled();
            this.Volume = percent switch
            {
                < 0 => 0,
                > 100 => 100,
                _ => percent
            };

            Console.WriteLine("TV Volume: {0}", this.Volume);
        }

        public int GetChannel()
        {
            CheckIsEnabled();
            return this.Channel;
        }

        public void SetChannel(int channel)
        {
            CheckIsEnabled();
            this.Channel = channel switch
            {
                < 0 => 0,
                > 10 => 10,
                _ => channel
            };

            Console.WriteLine("TV Channel: {0}", this.Channel);
        }

        private void CheckIsEnabled()
        {
            if (!this.IsEnabled)
            {
                throw new DeviceTvDisabledException();
            }
        }
    }
}
