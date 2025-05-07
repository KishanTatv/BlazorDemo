using Microsoft.AspNetCore.Components.Forms;
using SMS.Shared.Static.Constants;
using System.ComponentModel.DataAnnotations;

namespace SMS.DataAccess.Models.Student.Request
{
    public class StudentListReqDTO : FilterViewModel
    {
        public int YearId { get; set; }
        public string? SearchByName { get; set; }
        public int? StaffId { get; set; }
    }

    public class StudentAddReqDTO
    {
        public int StudentId { get; set; }

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

        public string Building { get; set; }

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
        public int CreatedBy { get; set; }
        public int ModifiedBy { get; set; }
        public int YearId { get; set; }

    }

    public class DivisionDrop
    {
        [Display(Name = "division")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        public int DivisionId { get; set; }

        public int RollNumberGenerationId { get; set; } = 1;
        public int RollNumber { get; set; } = 1;
        public int StudentId { get; set; }
        public int YearId { get; set; }
        public int? CreatedBy { get; set; }
        public int? ModifiedBy { get; set; }
    }

    public class StudentImage()
    {
        public int StudentId { get; set; }
        public IBrowserFile StudentPhoto { get; set; }
    }

    public class StudentSchoolLeavingDetails
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        //public DateTime AdmissionDate { get; set; }
        public DateTime DateOfLeavingSchool { get; set; }

        [Display(Name = "progress")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [StringLength(20, ErrorMessage = ErrorMessage.InValidMsg, MinimumLength = 2)]
        [RegularExpression(FormRegEx.OnlyString, ErrorMessage = ErrorMessage.OnlyAlphabetMsg)]
        public string Progress { get; set; }

        [Display(Name = "conduct")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [StringLength(20, ErrorMessage = ErrorMessage.InValidMsg, MinimumLength = 2)]
        [RegularExpression(FormRegEx.OnlyString, ErrorMessage = ErrorMessage.OnlyAlphabetMsg)]
        public string Conduct { get; set; }

        [Display(Name = "leave reason")]
        [Required(ErrorMessage = ErrorMessage.RequiredMsg)]
        [StringLength(20, ErrorMessage = ErrorMessage.InValidMsg, MinimumLength = 10)]
        public string ReasonForLeavingSchool { get; set; }
        public int ModifiedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
    }

    public class AlumniStudentsRequestModel : FilterViewModel
    {
        public string? StudentName { get; set; }
        public string? FromDate { get; set; }
        public string? ToDate { get; set; }
    }
}
