using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

namespace NeoRMS.Storage
{
    public class GetSetSession
    {

        private readonly ProtectedSessionStorage _sessionStorage;

        public GetSetSession(ProtectedSessionStorage sessionStorage)
        {
            _sessionStorage = sessionStorage;
        }

        public async Task SetItemAsync(string key, object value)
        {
            await _sessionStorage.SetAsync(key, value);
        }

        public async Task<T> GetItemAsync<T>(string key)
        {
            var result = await _sessionStorage.GetAsync<T>(key);
            return result.Success ? result.Value : default;
        }

    }
}
