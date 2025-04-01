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

        public async Task<HttpResponseDTO<StudentDTO>> GetStudentInfo(int studentId)
        {
            HttpResponseDTO<StudentDTO> responseVM = await _httpClientManager.GetAsync<StudentDTO>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Student.GetStudent, _APIConnection) + "/" + studentId
                );
            return responseVM;
        }

        public async Task<HttpResponseDTO<bool>> AddStudent(StudentAddReqDTO model)
        {
            HttpResponseDTO<bool> responceVM = await _httpClientManager.PostAsync<bool>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Student.AddStudent, _APIConnection),
                TypeConversionUtility.ConvertToStringContent(model)
                );
            return responceVM;
        }

        public async Task<HttpResponseDTO<int>> TransferDivision(DivisionDrop model)
        {
            HttpResponseDTO<int> responceVM = await _httpClientManager.PostAsync<int>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Student.TransferDivision, _APIConnection),
                TypeConversionUtility.ConvertToStringContent(model)
                );
            return responceVM;
        }

        public async Task<HttpResponseDTO<string>> DeleteStudent(int studentId, int modifiedBy)
        {
            HttpResponseDTO<string> responseVM = await _httpClientManager.DeleteAsync<string>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Student.DeleteStudent, _APIConnection) +
                  UrlBuilderUtility.GenerateQueryString([
                      new KeyValuePair<string,string>("studentId", studentId.ToString()),
                      new KeyValuePair<string,string>("modifiedBy", modifiedBy.ToString())
                    ])
                  );
            return responseVM;
        }


        public async Task<HttpResponseDTO<string>> StudentPhoto(StudentImage model)
        {
            HttpResponseDTO<string> responseVM = await _httpClientManager.PostAsync<string>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Student.StudentPhoto, _APIConnection),
                FormDataUtility.ConvertToMultipartFormData(model)
                );

            return responseVM;
        }
    }
}
