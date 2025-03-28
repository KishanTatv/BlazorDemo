﻿using Microsoft.AspNetCore.Components.Forms;

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


    public class StudentListResponceVM
    {
        public IEnumerable<StudentListDTO> Students { get; set; }
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

}
