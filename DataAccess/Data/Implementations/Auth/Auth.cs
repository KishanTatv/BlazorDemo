using BlazorApp.Client.Models.Request.Auth;
using BlazorApp.Data.Interfaces.Auth;
using Microsoft.Extensions.Configuration;
using SMS.DataAccess.Data;
using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.HttpManager.Utility;
using SMS.Shared.Static.Routes;

namespace BlazorApp.Data.Implementations.Auth
{
    public class Auth : IAuth
    {
        private readonly IConfiguration _config;
        private readonly IHttpClientManager _httpClientManager;
        private readonly string _APIConnection;

        public Auth(IConfiguration config, IHttpClientManager httpClientManager)
        {
            _config = config;
            _httpClientManager = httpClientManager;
            _APIConnection = AppSettingsConfig.GetConnectionString(_config);
        }

        public async Task<HttpResponseDTO<List<string>>> Login(UserLoginDTO model)
        {
            HttpResponseDTO<List<string>> responseVM = await _httpClientManager.PostAsync<List<string>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Auth.LoginRoute, _APIConnection),
                TypeConversionUtility.ConvertToStringContent(model)
                );
            return responseVM;
        }
    }
}
