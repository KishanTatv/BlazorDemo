using Microsoft.AspNetCore.Components.Forms;

namespace SMS.DataAccess.Models.Student.Response
{
    public class StudentListDTO
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ClassId { get; set; }
        public int DivisionId { get; set; }
        public string ClassName { get; set; }
        public string DivisionName { get; set; }
    }


    public class StudentListResponceVM<T>
    {
        public IEnumerable<T> Students { get; set; }
        public int TotalItemCount { get; set; } = 0;
    }

    public class StudentDTO
    {
        public int StudentId { get; set; }
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string BuildingName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int Gender { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ClassId { get; set; }
        public int DivisionId { get; set; }
        public string? ClassName { get; set; }
        public string? DivisionName { get; set; }
        public int CreatedBy { get; set; }
    }


    public class AlumiStudentModel
    {
        public int StudentId { get; set; }
        public int? UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string AadharCardNumber { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }
        public DateTime AdmissionDate { get; set; }
        public string? PreviousSchoolName { get; set; }
        public string BuildingName { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int ZipCode { get; set; }
        public int Gender { get; set; }
        public int? BloodGroup { get; set; }
        public string? StudentPhotoPath { get; set; }
        public DateTime? DateOfLeavingSchool { get; set; }
        public string? Progress { get; set; }
        public string? Conduct { get; set; }
        public string? ReasonForLeavingSchool { get; set; }
        public DateTime DateOfBirth { get; set; }
        public int ClassId { get; set; }
        public int DivisionId { get; set; }
        public string? ClassName { get; set; }
        public string? DivisionName { get; set; }
        public int? RollNumber { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? PhotoId { get; set; }
    }
}
