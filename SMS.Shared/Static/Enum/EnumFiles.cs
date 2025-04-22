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

}
