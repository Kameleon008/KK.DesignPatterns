using KK.DesignPattern.Bridge.Devices;

namespace KK.DesignPattern.Bridge.DeviceControls
{
    internal class VoiceControl(IDevice device) : DeviceControl(device)
    {
        public void Mute()
        {
            this.Device.SetVolume(0);
        }
    }
}
