using System.ComponentModel;

namespace SMS.Shared.Static.Enum
{
    public enum UploadType
    {
        File = 1,
        Folder = 2,
    }

    public enum FileType
    {
        [Description(".zip")]
        zip = 1,
        [Description(".pdf")]
        pdf = 2,
        [Description(".jpg")]
        jpg = 3,
    }

    public enum FileSize
    {
        [Description("kb")]
        kb = 1,
        [Description("mb")]
        mb = 2,
        [Description("gb")]
        gb = 3,
        [Description("tb")]
        tb = 4,
    }

    public enum ExamType
    {
        [Description("Mid Term Exam")]
        MidTermExam = 1,
        [Description("Final Exam")]
        FinalExam = 2,
        [Description("Surprise Test")]
        SurpriseTest = 3,
        [Description("Unit Test")]
        UnitTest = 4,
    }

    public enum RoomType
    {
        ClassRoom = 1,
        ScienceLab = 2,
        ComputerLab = 3,
        Office = 4,
        Library = 5,
        Lobby = 6,
        WashRoom = 7,
        BlockedArea = 8,
        Other = 9
    }

}
