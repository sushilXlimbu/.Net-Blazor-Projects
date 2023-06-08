using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;
using System.Threading.Tasks;

namespace NeoRMS.Storage
{
    public class GetSetLocalStorage
    {
        private readonly ProtectedLocalStorage _localStorage;

        public GetSetLocalStorage(ProtectedLocalStorage localStorage)
        {
            _localStorage = localStorage;
        }

        public async Task SetItemAsync(string key, object value)
        {
            await _localStorage.SetAsync(key, value);
        }

        public async Task<T> GetItemAsync<T>(string key)
        {
            var result = await _localStorage.GetAsync<T>(key);
            return result.Success ? result.Value : default;
        }
    }
}
