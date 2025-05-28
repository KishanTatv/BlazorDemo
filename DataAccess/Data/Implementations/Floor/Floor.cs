using Microsoft.Extensions.Configuration;
using SMS.DataAccess.Data.Interfaces.Floor;
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

        public async Task<HttpResponseDTO<BuildingResponseDTO>> GetBuildingsList()
        {
            var response = await _httpClientManager.GetAsync<BuildingResponseDTO>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.FloorPlan.GetBuildingList, _APIConnection));
            return response;
        }

        public async Task<HttpResponseDTO<FloorResponseDTO>> GetFloorsList(FloorFilterDTO floorFilterDTO)
        {
            var response = await _httpClientManager.GetAsync<FloorResponseDTO>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.FloorPlan.GetFloorList, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(floorFilterDTO)
                );
            return response;
        }

        public async Task<HttpResponseDTO<RoomResponseDTO>> GetRoomsList(RoomFilterDTO roomFilterDTO)
        {
            var response = await _httpClientManager.GetAsync<RoomResponseDTO>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.FloorPlan.GetRoomList, _APIConnection) +
                UrlBuilderUtility.GenerateQueryStringFromDTO(roomFilterDTO));
            return response;
        }

        public async Task<HttpResponseDTO<List<RoomCoordinatesResponseDTO>>> GetRoomCellsListByFloorId(int floorId)
        {
            var response = await _httpClientManager.GetAsync<List<RoomCoordinatesResponseDTO>>(
                UrlBuilderUtility.GetCombineUrl(API_Routes.FloorPlan.GetRoomCellsListByFloorId, _APIConnection) +
                UrlBuilderUtility.GenerateQueryString(
                   [new KeyValuePair<string, string>("FloorId", floorId.ToString())]
               ));
            return response;
        }


    }
}
