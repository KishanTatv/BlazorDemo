using System.ComponentModel.DataAnnotations;

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
    }
}
