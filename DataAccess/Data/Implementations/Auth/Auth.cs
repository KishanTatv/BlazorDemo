using BlazorApp.Client.Models.Request.Auth;
using BlazorApp.Data.Interfaces.Auth;
using Microsoft.Extensions.Configuration;
using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;

namespace BlazorApp.Data.Implementations.Auth
{
    public class Auth : IAuth
    {
        private readonly IConfiguration _config;
        private readonly HttpClient _httpClient;
        private readonly string _APIConnection;

        public Auth(IConfiguration config, HttpClient httpClient)
        {
            _config = config;
            _httpClient = httpClient;
        }

        public async Task<HttpResponseDTO<List<string>>> Login(UserLoginDTO model)
        {
            string x = _config.GetConnectionString("ApiBaseUrl");
            //HttpResponseDTO<List<string>> responseVM = await _httpClientManager.PostAsync<List<string>>('')
            throw new NotImplementedException();
        }
    }
}
