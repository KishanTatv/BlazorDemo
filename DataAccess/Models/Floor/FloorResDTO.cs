namespace SMS.DataAccess.Models.Floor
{
    public class BuildingResponseDTO
    {
        public List<BuildingDTO> Buildings { get; set; }
        public int TotalCount { get; set; }
    }

    public class FloorResponseDTO
    {
        public List<FloorDTO>? Floors { get; set; }
        public int? TotalCount { get; set; }
    }

    public class FloorDTO
    {
        public int FloorId { get; set; }
        public string? FloorNumber { get; set; }
        public string? BuildingName { get; set; }
        public int? BuildingId { get; set; }
        public int? UserId { get; set; }
        public int TotalRooms { get; set; }
        public int TotalCount { get; set; }
    }

    public class RoomCoordinatesResponseDTO
    {
        public int RoomCellId { get; set; }
        public int RoomId { get; set; }
        public int RoomType { get; set; }
        public string? RoomNumber { get; set; }
        public int CellX { get; set; }
        public int CellY { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class RoomDTO
    {
        public int RoomId { get; set; }
        public string? RoomNumber { get; set; }
        public int FloorId { get; set; }
        public int BuildingId { get; set; }
        public string? FloorNumber { get; set; }
        public int RoomType { get; set; }
        public int Capacity { get; set; }
        public string? Description { get; set; }
        public string? BuildingName { get; set; }
        public int UserId { get; set; }
        public int TotalCount { get; set; }
        public int? CellX { get; set; }
        public int? CellY { get; set; }
        public int? Height { get; set; }
        public int? Width { get; set; }
        public string? Color { get; set; }
    }

    public class RoomResponseDTO
    {
        public List<RoomDTO>? Rooms { get; set; }
        public int TotalCount { get; set; }
    }


}
