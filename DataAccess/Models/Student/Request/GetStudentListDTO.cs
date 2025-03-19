namespace SMS.DataAccess.Models.Auth.Request
{
    public class GetStudentListDTO
    {
        public int YearId { get; set; }
        public int DisplayStart { get; set; }
        public int DisplayLength { get; set; }
        public string StudentName { get; set; }
        public string SortCol {  get; set; }
        public string SortDir { get; set; }
        public string? SearchByName { get; set; }
    }

    public class Employee1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
    }
}
