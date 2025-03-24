using SMS.Shared.Static.Constants;
using System.ComponentModel.DataAnnotations;

namespace SMS.DataAccess.Models.Student.Request
{
    public class StudentListReqDTO
    {
        public int YearId { get; set; }
        public int DisplayStart { get; set; }
        public int DisplayLength { get; set; }
        public string SortCol {  get; set; }
        public string SortDir { get; set; }
        public string? SearchByName { get; set; }
    }

    public class StudentAddReqDTO
    {
        [Display(Name = "first name")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [StringLength(25, ErrorMessage = ErrorMessage.WrongLengthMsg, MinimumLength = 2)]
        [RegularExpression(FormRegEx.OnlyString, ErrorMessage = ErrorMessage.OnlyAlphabetMsg)]
        public string FirstName { get; set; }

        [Display(Name = "last name")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [StringLength(25, ErrorMessage = ErrorMessage.WrongLengthMsg, MinimumLength = 2)]
        [RegularExpression(FormRegEx.OnlyString, ErrorMessage = ErrorMessage.OnlyAlphabetMsg)]
        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

        [Display(Name = "gender")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        public int? Gender { get; set; }

        [Display(Name = "email")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [EmailAddress(ErrorMessage = ErrorMessage.InValidMsg)]
        public string Email { get; set; }

        [Display(Name = "phone no")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [RegularExpression(FormRegEx.Phone, ErrorMessage = ErrorMessage.InValidMsg)]
        public string Phone { get; set; }

        [Display(Name = "class")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        public int ClassId { get; set; }

        [Display(Name = "division")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        public int DivisionId { get; set; }
        public DateTime AdmissionDate { get; set; } = DateTime.Now.Date;

        [Display(Name = "city")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [StringLength(20, ErrorMessage = ErrorMessage.InValidMsg, MinimumLength = 2)]
        [RegularExpression(FormRegEx.OnlyString, ErrorMessage = ErrorMessage.OnlyAlphabetMsg)]
        public string City { get; set; }

        [Display(Name = "state")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [StringLength(20, ErrorMessage = ErrorMessage.InValidMsg, MinimumLength = 2)]
        [RegularExpression(FormRegEx.OnlyString, ErrorMessage = ErrorMessage.OnlyAlphabetMsg)]
        public string State { get; set; }

        [Display(Name = "zipcode")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [RegularExpression(FormRegEx.ZipCode, ErrorMessage = ErrorMessage.InValidMsg)]
        public string ZipCode { get; set; }
    }
}
