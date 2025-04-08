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

}
