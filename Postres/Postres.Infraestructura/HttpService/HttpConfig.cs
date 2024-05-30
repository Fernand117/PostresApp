using Newtonsoft.Json;
using System.Text;

namespace Postres.Infraestructura.HttpService
{
    public class HttpConfig : IHttpConfig
    {
        private readonly HttpClient _httpClient;

        public HttpConfig(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentException(nameof(httpClient));
        }

        public async Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            return await _httpClient.GetAsync(requestUri);
        }

        public async Task<HttpResponseMessage> PostAsync<T>(string requestUri, T content)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return await _httpClient.PostAsync(requestUri, jsonContent);
        }

        public async Task<HttpResponseMessage> PutAsync<T>(string requestUri, T content)
        {
            var jsonContent = new StringContent(JsonConvert.SerializeObject(content), Encoding.UTF8, "application/json");
            return await _httpClient.PutAsync(requestUri, jsonContent);
        }

        public async Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            return await _httpClient.DeleteAsync(requestUri);
        }
    }
}
