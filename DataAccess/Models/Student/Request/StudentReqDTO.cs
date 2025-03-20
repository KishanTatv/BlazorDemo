using System.ComponentModel.DataAnnotations;

namespace SMS.DataAccess.Models.Student.Request
{
    public class StudentListReqDTO
    {
        public int YearId { get; set; }
        public int DisplayStart { get; set; }
        public int DisplayLength { get; set; }
        public string StudentName { get; set; }
        public string SortCol {  get; set; }
        public string SortDir { get; set; }
        public string? SearchByName { get; set; }
    }

    public class StudentAddReqDTO
    {
        [Required(ErrorMessage = "FirstName is required")]
        [StringLength(25, ErrorMessage = "FirstName length must be between 2 and 25 character.", MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string FirstName {  get; set; }

        [Required(ErrorMessage = "LastName is required")]
        [StringLength(25, ErrorMessage = "LastName length must be between 2 and 25 character.", MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Required(ErrorMessage = "Email is required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone no is required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "Wrong mobile")]
        public string Phone { get; set; }

        [Required(ErrorMessage = "Class is required")]
        public int ClassId { get; set; }
        [Required(ErrorMessage = "Division is required")]
        public int DivisionId { get; set; }
        public DateTime AdmissionDate { get; set; } = DateTime.Now.Date;

        [Required(ErrorMessage = "City is required")]
        [StringLength(20, ErrorMessage = "Invalid city name", MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string City { get; set; }
        
        [Required(ErrorMessage = "State is required")]
        [StringLength(20, ErrorMessage = "Invalid state name.", MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Use letters only please")]
        public string State { get; set; }
    }
}
