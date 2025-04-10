using SMS.DataAccess.Models;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces
{
    public interface ICommon
    {
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetAllClassesAsync();
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetClassesByTeacherIdAsync(int teacherId, int yearId);
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetDivisionsByClassAsync(int classId);
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetSubjectByClassAsync(int classId, int yearId);
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetSubjectsByTeacherClassDivisionAsync(int classId, int teacherId, int yearId);
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetSubjectsByStudentAsync(int studentId, int yearId);
    }
}
