
namespace Postres.Infraestructura.HttpService
{
    public class HttpConfig : IHttpConfig
    {
        private readonly HttpClient _httpClient;

        public HttpConfig(HttpClient httpClient)
        {
            _httpClient = httpClient ?? throw new ArgumentException(nameof(httpClient));
        }

        public Task<HttpResponseMessage> DeleteAsync(string requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> GetAsync(string requestUri)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PostAsync<T>(string requestUri, T content)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseMessage> PutAsync<T>(string requestUri, T content)
        {
            throw new NotImplementedException();
        }
    }
}
