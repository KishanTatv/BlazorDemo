﻿using SMS.DataAccess.Models.StudyMaterial;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces.StudyMaterial
{
    public interface IStudyMaterial
    {
        Task<HttpResponseDTO<List<StudyMaterialResponceDTO>>> GetStudyMaterialAsync(StudyMaterialFilterDTO filters);
        Task<HttpResponseDTO<StudyMaterialModel>> GetSpecificMaterial(int studyMaterialId);
        Task<byte[]> DownloadMaterial(StudyMaterialFileDownloadDTO filterData);
        Task<HttpResponseDTO<bool>> DeleteMaterial(DeleteMaterialReq reqModel);
        Task<HttpResponseDTO<bool>> AddMaterial(MaterialUpload uploadModal, int studyMaterialId);
    }
}
