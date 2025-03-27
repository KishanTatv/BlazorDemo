using SMS.DataAccess.Models.Student.Request;
using SMS.DataAccess.Models.Student.Response;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces.Student
{
    public interface IStudent
    {
        Task<HttpResponseDTO<StudentListResponceVM>> GetStudentList(StudentListReqDTO model);
        Task<HttpResponseDTO<StudentDTO>> GetStudentInfo(int studentId);
        Task<HttpResponseDTO<bool>> AddStudent(StudentAddReqDTO model);
        Task<HttpResponseDTO<int>> TransferDivision(DivisionDrop model);
        Task<HttpResponseDTO<bool>> DeleteStudent(int studentId, int modifiedBy);
    }
}
