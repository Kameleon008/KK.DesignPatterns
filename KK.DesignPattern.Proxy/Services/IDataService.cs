namespace KK.DesignPattern.Proxy.Services
{
    public interface IDataService
    {
        public Task<string> GetItemAsync(int id);

    }
}
