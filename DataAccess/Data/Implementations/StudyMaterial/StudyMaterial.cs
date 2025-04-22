using Microsoft.Extensions.Configuration;
using SMS.DataAccess.Data.Interfaces.StudyMaterial;
using SMS.DataAccess.Models.StudyMaterial;
using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.HttpManager.Utility;
using SMS.Shared.Static.Routes;

namespace SMS.DataAccess.Data.Implementations.StudyMaterial
{
    public class StudyMaterial : IStudyMaterial
    {
        private readonly IHttpClientManager _httpClientManager;
        private readonly string _APIConnection;

        public StudyMaterial(IConfiguration config, IHttpClientManager httpClientManager)
        {
            _httpClientManager = httpClientManager;
            _APIConnection = AppSettingsConfig.GetConnectionString(config);
        }

        public async Task<HttpResponseDTO<List<StudyMaterialResponceDTO>>> GetStudyMaterialAsync(StudyMaterialFilterDTO filters)
        {
            HttpResponseDTO<List<StudyMaterialResponceDTO>> responceVM = await _httpClientManager.GetAsync<List<StudyMaterialResponceDTO>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.StudyMaterial.MaterialList, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(filters));
            return responceVM;
        }

        public async Task<HttpResponseDTO<StudyMaterialModel>> GetSpecificMaterial(int studyMaterialId)
        {
            HttpResponseDTO<StudyMaterialModel> responseVM = await _httpClientManager.GetAsync<StudyMaterialModel>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.StudyMaterial.GetStudyMaterialById, _APIConnection) +
                UrlBuilderUtility.GenerateQueryString(
                   [new KeyValuePair<string, string>("studyMaterialId", studyMaterialId.ToString())]
               ));
            return responseVM;
        }

        public async Task<byte[]> DownloadMaterial(StudyMaterialFileDownloadDTO filterData)
        {
            string url = UrlBuilderUtility.GetCombineUrl(API_Routes.StudyMaterial.DownloadStudyMaterial, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(filterData);
            return await _httpClientManager.GetBlobAsync(url);
        }

        public async Task<HttpResponseDTO<bool>> DeleteMaterial(DeleteMaterialReq reqModel)
        {
            HttpResponseDTO<bool> responseVM = await _httpClientManager.GetAsync<bool>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.StudyMaterial.DeleteMaterial, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(reqModel));
            return responseVM;
        }

        public async Task<HttpResponseDTO<bool>> AddMaterial(MaterialUpload uploadModal, int studyMaterialId)
        {
            string url = UrlBuilderUtility.GetCombineUrl(API_Routes.StudyMaterial.SaveMaterial, _APIConnection);
            if (studyMaterialId > 0)
            {
                url = url + UrlBuilderUtility.GenerateQueryString([new KeyValuePair<string, string>("studyMaterialId", studyMaterialId.ToString())]);
            }
            HttpResponseDTO<bool> responseVM = await _httpClientManager.PostAsync<bool>(
                url, FormDataUtility.ConvertToMultipartFormData(uploadModal)
                );
            return responseVM;
        }
    }
}
