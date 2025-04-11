namespace SMS.DataAccess.Models.StudyMaterial
{
    public class StudyMaterialResponceDTO
    {
        public int studyMaterialId { get; set; }
        public int parentMaterialId { get; set; }
        public int materialSize { get; set; }
        public string materialType { get; set; }
        public string fileName { get; set; }
        public string description { get; set; }
        public bool isShow { get; set; }
        public string uploadedBy { get; set; }
        public DateTime uploadedDate { get; set; }
    }

    public class StudyMaterialModel
    {
        public int StudyMaterialId { get; set; }
        public string FileName { get; set; }
        public string? FilePath { get; set; }
        public string MaterialType { get; set; }
        public int MaterialSize { get; set; }
        public string Description { get; set; }
        public bool IsShow { get; set; }
        public int ParentMaterialId { get; set; }
        public string UploadedBy { get; set; }
        public DateTime UploadedDate { get; set; }

    }
}
