using Microsoft.Extensions.Configuration;
using SMS.DataAccess.Data.Interfaces.Floor;
using SMS.DataAccess.Models;
using SMS.DataAccess.Models.Floor;
using SMS.Shared.HttpManager.DTO;
using SMS.Shared.HttpManager.Interface;
using SMS.Shared.HttpManager.Utility;
using SMS.Shared.Static.Routes;

namespace SMS.DataAccess.Data.Implementations.Floor
{
    public class Floor : IFloor
    {
        private readonly IHttpClientManager _httpClientManager;
        private readonly string _APIConnection;

        public Floor(IConfiguration config, IHttpClientManager httpClientManager)
        {
            _httpClientManager = httpClientManager;
            _APIConnection = AppSettingsConfig.GetConnectionString(config);
        }

        public async Task<HttpResponseDTO<List<SelectOptionDTO>>> GetBuildingsList()
        {
            var response = await _httpClientManager.GetAsync<List<SelectOptionDTO>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Common.GetBuildingList, _APIConnection));
            return response;
        }

        public async Task<HttpResponseDTO<List<SelectOptionDTO>>> GetFloorsList(FloorFilterDTO filterDTO)
        {
            var response = await _httpClientManager.GetAsync<List<SelectOptionDTO>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.Common.GetFloorList, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(filterDTO)
                );
            return response;
        }

        public async Task<HttpResponseDTO<List<RoomCoordinatesResponseDTO>>> GetRoomCellsListByFloorId(FloorFilterDTO filterDTO)
        {
            var response = await _httpClientManager.GetAsync<List<RoomCoordinatesResponseDTO>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.FloorPlan.GetRoomCellsListByFloorId, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(filterDTO)
                );
            return response;
        }

        public async Task<HttpResponseDTO<bool>> UpdateRoomCoordinate(List<RoomsCellsViewModel> filterDTO)
        {
            var response = await _httpClientManager.PostAsync<bool>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.FloorPlan.UpdateRoomCells, _APIConnection),
                TypeConversionUtility.ConvertToStringContent(filterDTO)
                );
            return response;
        }

        public async Task<HttpResponseDTO<bool>> FloorFinalize(int floorId)
        {
            var response = await _httpClientManager.PostAsync<bool>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.FloorPlan.UpdateFloorFinalize, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(new { FloorId = floorId }), null
                );
            return response;
        }
    }
}
