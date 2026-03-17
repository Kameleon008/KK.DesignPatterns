namespace KK.DesignPattern.Proxy.Services
{
    internal class DataService : IDataService
    {
        public async Task<string> GetItemAsync(int id)
        {
            await Task.Delay(new Random().Next(500,2000));
            return $"HERE ARE DATA FOR ITEM WITH ID: {id}";
        }
    }
}
