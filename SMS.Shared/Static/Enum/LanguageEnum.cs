using System.ComponentModel;

namespace SMS.Shared.Static.Enum
{
    public static class LanguageEnum
    {
        public enum Languages
        {
            [Description("en-US")]
            English,

            [Description("hi-IN")]
            Hindi
        }

        public enum MultiLanguals
        {
            [Description("Welcome the Application")]
            WelcomeMessage,
            [Description("Hello World!")]
            HelloWorld,
            [Description("Class")]
            Class,
            [Description("Subject")]
            Subject,
            [Description("File Name")]
            FileName,
            [Description("Search")]
            Search,
            [Description("Clear")]
            Clear,
            [Description("File/Folder Name")]
            FileFolderName,
            [Description("Description")]
            Description,
            [Description("Size")]
            Size,
            [Description("Uploaded Date")]
            UploadedDate,
            [Description("Uploaded By")]
            UploadedBy,
            [Description("Action")]
            Action
        }
    }
}
