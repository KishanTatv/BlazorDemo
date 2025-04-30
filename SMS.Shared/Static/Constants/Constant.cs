namespace SMS.Shared.Static.Constants
{
    public static class HttpResponseMessages
    {
        public static string msgHttpConnectionFailed = "Failed to connect with Http to make requests";
        public static string msgHttpRequestFailed = "Failed to get Http Response";
        public static string msgNotFound = "Failed to get Http Response";
    }

    public static class SystemMessage
    {
        public static string msgSomethingWrong = "Something Wrong !";
        public static string msgTryAgain = "Plaese try again !";
        public static string msgFileEmpty = "File is Empty !";
        public static string msgFileDownloadProcess = "Downloading in Process...";
        public static string msgFileDownloadComplete = "Downloading Completed!";
    }

    public static class JsStaticFun
    {
        public static string blazorCultureGet = "blazorCulture.get";
        public static string blazorCultureSet = "blazorCulture.set";
        public static string downloadFileStream = "downloadFileFromStream";
    }

    public static class PageHeading
    {
        public const string Dashboard = "Dashboard";
        public const string StudyMaterial = "Study Material";
        public const string Student = "Student";
        public const string AlumniStudent = "Alumni Student";
        public const string StaffTask = "Staff Task";
        public const string AcademicPerformance = "Academic Performance";
    }

    public static class FixFileName
    {
        public static string LCReport = "LC-Certificate";
    }

    public static class GridTable
    {
        public static int PageSize = 10;
        public static int FixHeight = 466;
        public static int[] PageSizeOption = { 5, 10, 20 };
        public static string SortAsc = "asc";
        public static string SortDesc = "desc";
    }

    public static class DateFormat
    {
        public static string ddMMMyyyy = "dd MMM, yyyy";
        public static string MMMMyyyy = "MMMM yyyy";
        public static string yyyy_MM_ddT = "yyyy-MM-ddT00:00:00";
    }




    //regEx
    public static class FormRegEx
    {
        public const string OnlyString = @"^[a-zA-Z]+$";
        public const string Phone = @"^(\d{10})$";
        public const string ZipCode = @"^\d{6}(-\d{4})?$";
    }

    public static class ErrorMessage
    {
        public const string RequiredMsg = "{0} feild is required.";
        public const string InValidMsg = "please enter a valid {0} feild.";
        public const string OnlyAlphabetMsg = "please enter only alphabets.";
        public const string WrongLengthMsg = "{0} length must be between 2 and 25 character.";
    }
}
