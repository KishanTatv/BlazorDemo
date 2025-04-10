using SMS.Shared.HttpManager.DTO;

namespace SMS.Shared.HttpManager.Interface
{
    public interface IHttpClientManager
    {
        Task<HttpResponseDTO<T>> GetAsync<T>(string url);
        Task<HttpResponseDTO<T>> PostAsync<T>(string demoRoute, HttpContent content);
        Task<HttpResponseDTO<T>> DeleteAsync<T>(string url);
        Task<byte[]> GetBlobAsync(string url);
    }
}
