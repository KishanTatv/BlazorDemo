using SMS.DataAccess.Models.Student.Request;
using SMS.DataAccess.Models.Student.Response;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces.Student
{
    public interface IStudent
    {
        Task<HttpResponseDTO<StudentListResponceVM<StudentListDTO>>> GetStudentList(StudentListReqDTO model);
        Task<HttpResponseDTO<StudentDTO>> GetStudentInfo(int studentId);
        Task<HttpResponseDTO<bool>> AddStudent(StudentAddReqDTO model);
        Task<HttpResponseDTO<int>> TransferDivision(DivisionDrop model);
        Task<HttpResponseDTO<string>> DeleteStudent(int studentId, int modifiedBy);


        Task<HttpResponseDTO<string>> StudentPhoto(StudentImage model);
        Task<HttpResponseDTO<int>> StudentLeaving(StudentSchoolLeavingDetails model);
        Task<HttpResponseDTO<StudentListResponceVM<AlumiStudentModel>>> AlumniStudent(AlumniStudentsRequestModel model);
    }
}
