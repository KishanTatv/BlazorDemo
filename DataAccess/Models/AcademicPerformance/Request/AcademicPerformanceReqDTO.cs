namespace SMS.DataAccess.Models.AcademicPerformance.Request
{
    public class PerformanceRequestDTO
    {
        public int ClassId { get; set; }
        public int? DivisionId { get; set; }
        public int YearId { get; set; } = 1;
    }
}
