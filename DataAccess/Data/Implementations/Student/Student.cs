using Microsoft.Extensions.Configuration;
using SMS.DataAccess.Data.Interfaces.Student;
using SMS.DataAccess.Models.Student.Request;
using SMS.DataAccess.Models.Student.Response;
using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.HttpManager.Utility;
using SMS.Shared.Static.Routes;

namespace SMS.DataAccess.Data.Implementations.Student
{
    public class Student : IStudent
    {
        private readonly IHttpClientManager _httpClientManager;
        private readonly string _APIConnection;

        public Student(IConfiguration config, IHttpClientManager httpClientManager)
        {
            _httpClientManager = httpClientManager;
            _APIConnection = AppSettingsConfig.GetConnectionString(config);
        }

        public async Task<HttpResponseDTO<StudentListResponceVM>> GetStudentList(StudentListReqDTO model)
        {
            HttpResponseDTO<StudentListResponceVM> responseVM = await _httpClientManager.GetAsync<StudentListResponceVM>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Student.StudentList, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(model)
                );

            return responseVM;
        }
    }
}
