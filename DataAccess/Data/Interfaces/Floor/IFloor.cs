using SMS.DataAccess.Models;
using SMS.DataAccess.Models.Floor;
using SMS.Shared.HttpManager.DTO;

namespace SMS.DataAccess.Data.Interfaces.Floor
{
    public interface IFloor
    {
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetBuildingsList();
        Task<HttpResponseDTO<List<SelectOptionDTO>>> GetFloorsList(FloorFilterDTO filterDTO);
        Task<HttpResponseDTO<List<RoomCoordinatesResponseDTO>>> GetRoomCellsListByFloorId(FloorFilterDTO filterDTO);
        Task<HttpResponseDTO<bool>> UpdateRoomCoordinate(List<RoomsCellsViewModel> filterDTO);
        Task<HttpResponseDTO<bool>> FloorFinalize(int floorId);
    }
}
