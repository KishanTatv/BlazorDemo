namespace SMS.Shared.Static.Routes
{
    public static class API_Routes
    {
        public class Common
        {
            public const string GetAllClasses = "common/GetClassList";
            public const string GetDivisionsByClass = "common/GetDivisionListByClass";
        }

        public class Auth
        {
            public const string LoginRoute = "Auth/Login";
            public const string ForgetPassword = "Auth/ForgetPassword";
        }

        public class Student
        {
            public const string StudentList = "Student/GetStudentList";
        }
    }
}
