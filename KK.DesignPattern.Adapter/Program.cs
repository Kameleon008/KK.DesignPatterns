namespace KK.DesignPattern.Adapter;

public static class Program
{
    public static void Main()
    {
        const string filePath = "Master of Puppets.MP3";

        var musicPlayers = new List<IAudioPlayer>
        {
            new WindowsMediaPlayer(),
            new VLCPlayerAdapter(new VLCPLayer())
        };

        foreach (var musicPlayer in musicPlayers)
        {
            Console.WriteLine();
            musicPlayer.Play(filePath);
        }
    }
}