using KK.DesignPattern.Bridge.DeviceControls;
using KK.DesignPattern.Bridge.Devices;

public static class Program
{
    public static void Main()
    {
        var voiceControlRadio = new VoiceControl(new DeviceRadio());
        var remoteControlTv = new RemoteControl(new DeviceTv());

        Console.WriteLine();
        Console.WriteLine("Voice Control Radio");
        voiceControlRadio.TogglePower();
        voiceControlRadio.VolumeUp();
        voiceControlRadio.VolumeUp();
        voiceControlRadio.VolumeUp();
        voiceControlRadio.ChannelUp();
        voiceControlRadio.Mute();

        Console.WriteLine();
        Console.WriteLine("Remote Control TV");
        remoteControlTv.TogglePower();
        remoteControlTv.VolumeUp();
        remoteControlTv.VolumeUp();
        remoteControlTv.VolumeUp();
        remoteControlTv.ChannelUp();
        remoteControlTv.SetChannel((int)RadioChannel.MusicRadioChannel);

        var voiceControlTv = new VoiceControl(new DeviceTv());
        var remoteControlRadio = new RemoteControl(new DeviceRadio());

        Console.WriteLine();
        Console.WriteLine("Voice Control TV");
        voiceControlTv.TogglePower();
        voiceControlTv.VolumeUp();
        voiceControlTv.VolumeUp();
        voiceControlTv.VolumeUp();
        voiceControlTv.ChannelUp();
        voiceControlTv.Mute();

        Console.WriteLine();
        Console.WriteLine("Remote Control Radio");
        remoteControlRadio.TogglePower();
        remoteControlRadio.VolumeUp();
        remoteControlRadio.VolumeUp();
        remoteControlRadio.VolumeUp();
        remoteControlRadio.ChannelUp();
        remoteControlRadio.SetChannel((int)RadioChannel.MusicRadioChannel);

    }
}