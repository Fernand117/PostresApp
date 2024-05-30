namespace Postres.Infraestructura.HttpService
{
    public interface IHttpConfig
    {
        Task<HttpResponseMessage> GetAsync(string requestUri);
        Task<HttpResponseMessage> PostAsync<T>(string requestUri, T content);
        Task<HttpResponseMessage> PutAsync<T>(string requestUri, T content);
        Task<HttpResponseMessage> DeleteAsync(string requestUri);
    }
}
