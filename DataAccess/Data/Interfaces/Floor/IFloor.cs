using SMS.DataAccess.Models.Floor;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces.Floor
{
    public interface IFloor
    {
        Task<HttpResponseDTO<BuildingResponseDTO>> GetBuildingsList();
        Task<HttpResponseDTO<FloorResponseDTO>> GetFloorsList(FloorFilterDTO floorFilterDTO);
        Task<HttpResponseDTO<RoomResponseDTO>> GetRoomsList(RoomFilterDTO roomFilterDTO);
        Task<HttpResponseDTO<List<RoomCoordinatesResponseDTO>>> GetRoomCellsListByFloorId(int floorId);
    }
}
