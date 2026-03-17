
namespace KK.DesignPattern.Proxy.Services
{
    internal class DataServiceCachingProxy(IDataService dataService) : IDataService
    {
        private readonly Dictionary<int, string> _cachedDate = new();

        public async Task<string> GetItemAsync(int id)
        {
            try
            {
                if (_cachedDate.TryGetValue(id, out var async))
                {
                    return async;
                }

                var result = await dataService.GetItemAsync(id);

                _cachedDate.Add(id, result);

                return result;
            }
            catch (Exception exception)
            {
                return exception.Message;
            }
        }
    }
}
