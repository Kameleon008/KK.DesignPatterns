namespace KK.DesignPattern.Adapter
{
    internal class WindowsMediaPlayer : IAudioPlayer
    {
        public void Play(string fileName)
        {
            Console.WriteLine("Windows Media Player plays the music: {0}", fileName);
        }
    }
}
