using SMS.DataAccess.Models.Auth.Request;
using SMS.DataAccess.Models.Student.Response;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces.Student
{
    public interface IStudent
    {
        Task<HttpResponseDTO<StudentListResponceVM>> GetStudentList(GetStudentListDTO model);
    }
}
