namespace SMS.Shared.JWTToken
{
    public class JwtDTO
    {
        public string UserName { get; set; } = "";
        public int role {  get; set; }
        public string Email { get; set; }
        public int CurrentYearId { get; set; }
        public int TeacherId { get; set; } = 0;
        public int StaffId { get; set; } = 0;
        public int ParentId { get; set; } = 0;
        public int StudentId { get; set; } = 0;
        public int UserId { get; set; }
    }
}
