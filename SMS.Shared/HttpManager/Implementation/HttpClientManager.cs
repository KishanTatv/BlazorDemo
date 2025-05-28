using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;
using System.Net.Http.Json;
using SMS.Shared.HttpManager.Utility.HttpResponce;
using SMS.Shared.Static.Constants;
using static SMS.Shared.Static.Enum.HttpStatusCodes;

namespace SMS.Shared.HttpManager.Implementation
{
    public class HttpClientManager : IHttpClientManager
    {
        private HttpClient _httpClient;
        public HttpClientManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<HttpResponseDTO<T>> GetAsync<T>(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<HttpResponseDTO<T>>() ?? HttpResponseUtility.HttpRequestFailedErrorResponse<T>();
                }
                else
                {
                    return HttpResponseUtility.HttpRequestFailedErrorResponse<T>();
                }
            }
            catch (Exception ex)
            {
                return HttpResponseUtility.HttpConnectionErrorResponse<T>();
            }
        }

        public async Task<HttpResponseDTO<T>> PostAsync<T>(string url, HttpContent? content)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.PostAsync(url, content);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<HttpResponseDTO<T>>() ?? HttpResponseUtility.HttpRequestFailedErrorResponse<T>();
                }
                else
                {
                    return HttpResponseUtility.HttpRequestFailedErrorResponse<T>();
                }
            }
            catch(Exception ex)
            {
                return HttpResponseUtility.HttpConnectionErrorResponse<T>();
            }
        }


        public async Task<HttpResponseDTO<T>> DeleteAsync<T>(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.DeleteAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadFromJsonAsync<HttpResponseDTO<T>>() ?? HttpResponseUtility.HttpRequestFailedErrorResponse<T>();
                }
                else
                {
                    return HttpResponseUtility.HttpRequestFailedErrorResponse<T>();
                }
            }
            catch (Exception ex)
            {
                return HttpResponseUtility.HttpConnectionErrorResponse<T>();
            }
        }

        public async Task<byte[]> GetBlobAsync(string url)
        {
            try
            {
                HttpResponseMessage response = await _httpClient.GetAsync(url);

                if (response.IsSuccessStatusCode)
                {
                    return await response.Content.ReadAsByteArrayAsync();
                }
                else
                {
                    throw new Exception($"{HttpResponseMessages.msgHttpRequestFailed}. StatusCode: {(int)HttpStatus.InternalServerError}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"{HttpResponseMessages.msgHttpConnectionFailed}. StatusCode: {(int)HttpStatus.InternalServerError}");
            }
        }


    }
}
