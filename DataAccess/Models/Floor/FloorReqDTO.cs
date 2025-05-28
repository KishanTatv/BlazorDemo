namespace SMS.DataAccess.Models.Floor
{
    public class BuildingDTO
    {
        public int BuildingId { get; set; }
        public string? BuildingName { get; set; }
        public string? Description { get; set; }
        public int? UserId { get; set; }
        public int TotalFloors { get; set; }
        public int TotalCount { get; set; }
    }

    public class FloorFilterDTO
    {
        public int? BuildingId { get; set; }
        public int? FloorId { get; set; }
        public int? RoomId { get; set; }
    }

    public class RoomCell
    {
        public int RoomId { get; set; }
        public int CellX { get; set; }
        public int CellY { get; set; }
    }

    public class RoomsCellsViewModel
    {
        public int RoomCellId { get; set; }
        public int RoomId { get; set; }
        public int RoomType { get; set; }
        public string RoomNumber { get; set; }
        public int CellX { get; set; }
        public int CellY { get; set; }
        public bool IsDeleted { get; set; }
    }

    public class Cell
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int? RoomId { get; set; }
        public bool IsSelected { get; set; }
    }
}
