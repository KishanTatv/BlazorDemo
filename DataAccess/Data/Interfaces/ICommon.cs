using SMS.DataAccess.Models;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces
{
    public interface ICommon
    {
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetAllClassesAsync();
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetDivisionsByClassAsync(int classId);
    }
}
