namespace SMS.Shared.JWTToken
{
    public class JwtDTO
    {
        public int role {  get; set; }
        public  int CurrentYearId { get; set; }
        public int TeacherId { get; set; } = 0;
        public int ParentId { get; set; } = 0;
        public int StudentId { get; set; } = 0;
        public int UserId { get; set; }
    }
}
