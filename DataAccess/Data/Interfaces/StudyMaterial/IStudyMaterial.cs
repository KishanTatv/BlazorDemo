using SMS.DataAccess.Models.StudyMaterial;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces.StudyMaterial
{
    public interface IStudyMaterial
    {
        Task<HttpResponseDTO<List<StudyMaterialResponceDTO>>> GetStudyMaterialAsync(StudyMaterialFilterDTO filters);
        Task<byte[]> DownloadMaterial(StudyMaterialFileDownloadDTO filterData);
        Task<HttpResponseDTO<bool>> DeleteMaterial(DeleteMaterialReq reqModel);
    }
}
