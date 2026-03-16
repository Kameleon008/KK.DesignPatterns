namespace KK.DesignPattern.Bridge.Devices
{
    internal interface IDevice
    {
        public bool IsEnabled { get;}

        public void Enable();

        public void Disable();

        public int GetVolume();

        public void SetVolume(int percent);

        public int GetChannel();

        public void SetChannel(int channel);

    }
}
