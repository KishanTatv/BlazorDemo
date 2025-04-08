using BlazorApp.Data.Interfaces.Auth;
using Microsoft.Extensions.Configuration;
using SMS.DataAccess.Data;
using SMS.DataAccess.Models.Auth.Request;
using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.HttpManager.Utility;
using SMS.Shared.Static.Routes;
using System.Reflection;

namespace BlazorApp.Data.Implementations.Auth
{
    public class Auth : IAuth
    {
        private readonly IHttpClientManager _httpClientManager;
        private readonly string _APIConnection;

        public Auth(IConfiguration config, IHttpClientManager httpClientManager)
        {
            _httpClientManager = httpClientManager;
            _APIConnection = AppSettingsConfig.GetConnectionString(config);
        }

        public async Task<HttpResponseDTO<List<string>>> Login(UserLoginDTO model)
        {
            HttpResponseDTO<List<string>> responseVM = await _httpClientManager.PostAsync<List<string>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Auth.LoginRoute, _APIConnection),
                TypeConversionUtility.ConvertToStringContent(model)
                );
            return responseVM;
        }

        public async Task<HttpResponseDTO<string>> GetUserPhoto(UserPhoto model)
        {
            HttpResponseDTO<string> responseVM = await _httpClientManager.GetAsync<string>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Auth.UserPhoto, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(model)
                );
            return responseVM;
        }
    }
}
