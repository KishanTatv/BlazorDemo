using Microsoft.Extensions.Configuration;
using SMS.DataAccess.Data.Interfaces.AcademicPerformance;
using SMS.DataAccess.Models;
using SMS.DataAccess.Models.AcademicPerformance.Request;
using SMS.DataAccess.Models.AcademicPerformance.Response;
using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.HttpManager.Utility;
using SMS.Shared.Static.Routes;

namespace SMS.DataAccess.Data.Implementations.AcademicPerformance
{
    public class AcademicPerformance : IAcademicPerformance
    {
        private readonly IHttpClientManager _httpClientManager;
        private readonly string _APIConnection;

        public AcademicPerformance(IConfiguration config, IHttpClientManager httpClientManager)
        {
            _httpClientManager = httpClientManager;
            _APIConnection = AppSettingsConfig.GetConnectionString(config);
        }

        public async Task<HttpResponseDTO<List<KeyPairDTO<double?>>>> GetSubjectBasePerformance(PerformanceRequestDTO requestDTO)
        {
            HttpResponseDTO<List<KeyPairDTO<double?>>> responseVM = await _httpClientManager.GetAsync<List<KeyPairDTO<double?>>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.AcademicPerformance.GetAcademicPerformanceSubjectWise, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(requestDTO));
            return responseVM;
        }

        public async Task<HttpResponseDTO<List<KeyPairDTO<double?>>>> GetExamBasePerformance(PerformanceRequestDTO requestDTO)
        {
            HttpResponseDTO<List<KeyPairDTO<double?>>> responseVM = await _httpClientManager.GetAsync<List<KeyPairDTO<double?>>> (
                UrlBuilderUtility.GetCombineUrl(API_Routes.AcademicPerformance.GetAcademicPerformanceExamWise, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(requestDTO));
            return responseVM;
        }
    }
}
