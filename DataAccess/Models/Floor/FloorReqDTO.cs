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

    public class FloorFilterDTO : FilterViewModel
    {
        public int BuildingId { get; set; }
    }

    public class FloorViewFilterDTO
    {
        public int? BuildingId { get; set; }
        public int? FloorId { get; set; }
        public int? RoomId { get; set; }
    }

    public class RoomFilterDTO : FilterViewModel
    {
        public int FloorId { get; set; }
        public string? RoomNumber { get; set; }
    }


}
