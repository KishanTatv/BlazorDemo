using Microsoft.Extensions.Configuration;
using SMS.DataAccess.Data.Interfaces;
using SMS.DataAccess.Models;
using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.HttpManager.Utility;
using SMS.Shared.Static.Routes;

namespace SMS.DataAccess.Data.Implementations
{
    public class Common : ICommon
    {
        private readonly IHttpClientManager _httpClientManager;
        private readonly string _APIConnection;

        public Common(IConfiguration config, IHttpClientManager httpClientManager)
        {
            _httpClientManager = httpClientManager;
            _APIConnection = AppSettingsConfig.GetConnectionString(config);
        }

        public async Task<HttpResponseDTO<List<SelectOptionDTO>>> GetAllClassesAsync()
        {
            return await _httpClientManager.GetAsync<List<SelectOptionDTO>>(
               UrlBuilderUtility.GetCombineUrl(API_Routes.Common.GetAllClasses, _APIConnection)
               );
        }

        public async Task<HttpResponseDTO<List<SelectOptionDTO>>> GetClassesByTeacherIdAsync(int teacherId, int yearId)
        {
            HttpResponseDTO<List<SelectOptionDTO>> responseVM = await _httpClientManager.GetAsync<List<SelectOptionDTO>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Common.GetClassesByTeacherId, _APIConnection) +
                UrlBuilderUtility.GenerateQueryString(
                    [new KeyValuePair<string,string>("staffId", teacherId.ToString()), new KeyValuePair<string, string>("yearId", yearId.ToString())]
                ));
            return responseVM;
        }


        public async Task<HttpResponseDTO<List<SelectOptionDTO>>> GetDivisionsByClassAsync(int classId)
        {
            return await _httpClientManager.GetAsync<List<SelectOptionDTO>>(
               UrlBuilderUtility.GetCombineUrl(API_Routes.Common.GetDivisionsByClass, _APIConnection) +
               UrlBuilderUtility.GenerateQueryString(
                   [
                   new KeyValuePair<string,string>("classId", classId.ToString()),
                   ]
               ));
        }

        public async Task<HttpResponseDTO<List<SelectOptionDTO>>> GetSubjectByClassAsync(int classId, int yearId)
        {
            return await _httpClientManager.GetAsync<List<SelectOptionDTO>>(
               UrlBuilderUtility.GetCombineUrl(API_Routes.Common.GetSubjectListByClass, _APIConnection) +
               UrlBuilderUtility.GenerateQueryString([
                   new KeyValuePair<string,string>("classId", classId.ToString()),
                   new KeyValuePair<string,string>("yearId", yearId.ToString()),
               ]));
        }

        public async Task<HttpResponseDTO<List<SelectOptionDTO>>> GetSubjectsByTeacherClassDivisionAsync(int classId, int teacherId, int yearId)
        {
            return await _httpClientManager.GetAsync<List<SelectOptionDTO>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Common.GetSubjectsByTeacherClassDivision, _APIConnection) +
                UrlBuilderUtility.GenerateQueryString(
                    [
                    new KeyValuePair<string,string>("classId", classId.ToString()),
                    new KeyValuePair<string,string>("staffId", teacherId.ToString()),
                    new KeyValuePair<string,string>("yearId", yearId.ToString()),
                    ]
                ));
        }

        public async Task<HttpResponseDTO<List<SelectOptionDTO>>> GetSubjectsByStudentAsync(int studentId, int yearId)
        {
            return await _httpClientManager.GetAsync<List<SelectOptionDTO>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Common.GetSubjectListByStudentId, _APIConnection) +
                UrlBuilderUtility.GenerateQueryString(
                    [
                    new KeyValuePair<string,string>("studentId", studentId.ToString()),
                    new KeyValuePair<string,string>("yearId", yearId.ToString()),
                    ]
                ));
        }



    }
}
