using Microsoft.AspNetCore.Components.Forms;
using System.ComponentModel.DataAnnotations;
using System.Net.NetworkInformation;

namespace SMS.DataAccess.Models.StudyMaterial
{
    public class StudyMaterialFilterDTO
    {
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select Valid Class")]
        public int ClassId { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Select Valid Division")]
        public int SubjectId { get; set; }
        public int? ParentMaterialId { get; set; } = null;
        public int StudentId { get; set; }
        public int RoleId { get; set; }
        public string Name { get; set; }
        public int YearId { get; set; }
    }

    public class StudyMaterialFileDownloadDTO
    {
        public int StudyMaterialId { get; set; }
        public int roleId { get; set; }
        public int subjectId { get; set; }
        public bool isFolder { get; set; }
    }

    public class DeleteMaterialReq
    {
        public int StudyMaterialId { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public bool IsFolder { get; set; }
    }

    public class MaterialUpload
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
        public List<IBrowserFile>? Files { get; set; }
        public bool ShowToStudents { get; set; }
        public int ClassId { get; set; }
        public int SubjectId { get; set; }
        public int UserId { get; set; }
        public int? ParentMaterialId { get; set; }
        public bool IsFolder { get; set; }
    }

}
