using SMS.DataAccess.Models;
using SMS.DataAccess.Models.AcademicPerformance.Request;
using SMS.DataAccess.Models.AcademicPerformance.Response;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces.AcademicPerformance
{
    public interface IAcademicPerformance
    {
        Task<HttpResponseDTO<List<KeyPairDTO<double?>>>> GetSubjectBasePerformance(PerformanceRequestDTO requestDTO);
        Task<HttpResponseDTO<List<KeyPairDTO<double?>>>> GetExamBasePerformance(PerformanceRequestDTO requestDTO);
    }
}
