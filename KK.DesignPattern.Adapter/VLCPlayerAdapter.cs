namespace KK.DesignPattern.Adapter
{
    internal class VLCPlayerAdapter(VLCPLayer player) : IAudioPlayer
    {
        private VLCPLayer player = player;

        public void Play(string fileName)
        {
            Console.WriteLine("VLCPlayerAdapter wrap VLCPlayer method PlayMusic()");
            this.player.PlayMusic(fileName);
        }
    }
}
