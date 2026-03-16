namespace KK.DesignPattern.Adapter
{
    internal class VLCPLayer
    {
        public void PlayMusic(string filePath)
        {
            Console.WriteLine("VLC Player plays the music: {0}", filePath);
        }
    }
}
