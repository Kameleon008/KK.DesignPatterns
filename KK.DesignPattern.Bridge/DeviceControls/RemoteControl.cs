using KK.DesignPattern.Bridge.Devices;

namespace KK.DesignPattern.Bridge.DeviceControls
{
    internal class RemoteControl(IDevice device) : DeviceControl(device)
    {
        public void SetChannel(int channel)
        {
            this.Device.SetChannel(channel);
        }
    }

    public enum RadioChannel
    {
        FavoriteRadioChannel = 0,
        RegionalRadioChannel = 1,
        MusicRadioChannel = 2,
        InformationChannel = 3,
    }
}
