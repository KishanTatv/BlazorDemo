namespace SMS.Shared.Static.Routes
{
    public static class API_Routes
    {
        public class Common
        {
            public const string GetAllClasses = "common/GetClassList";
            public const string GetClassesByTeacherId = "common/GetClassListByTeacherId";
            public const string GetDivisionsByClass = "common/GetDivisionListByClass";
            public const string GetSubjectListByClass = "common/GetSubjectListByClassId";
            public const string GetSubjectsByTeacherClassDivision = "common/GetSubjectListByTeacherAndClassAndDivision";
            public const string GetSubjectListByStudentId = "common/GetSubjectListByStudentId";
            public const string GetStudentListByParentId = "common/GetStudentListByParentId";
        }

        public class Auth
        {
            public const string LoginRoute = "Auth/Login";
            public const string ForgetPassword = "Auth/ForgetPassword";
            public const string UserPhoto = "Auth/GetUserPhoto";
            public const string Menu = "auth/menus";
        }

        public class Student
        {
            public const string StudentList = "Student/GetStudentList";
            public const string AddStudent = "Student/AddStudentSave";
            public const string GetStudent = "Student/GetStudentById";
            public const string TransferDivision = "Student/AllocateStudentRollNumber";
            public const string DeleteStudent = "Student/DeleteStudent";
            public const string StudentPhoto = "Student/StudentPhoto";
            public const string LeavingDetail = "Student/EditStudentSchoolLeavingDetails";
            public const string AlumniStudent = "Student/GetAllAlumniStudents";
            public const string DownloadLC = "Student/GetLeavingCertificate";
        }

        public class StudyMaterial
        {
            public const string GetStudyMaterialById = "StudyMaterial/GetStudyMaterialById";
            public const string MaterialList = "StudyMaterial/GetStudyMaterial";
            public const string DownloadStudyMaterial = "StudyMaterial/DownloadStudyMaterial";
            public const string DeleteMaterial = "StudyMaterial/DeleteStudyMaterial";
            public const string SaveMaterial = "StudyMaterial/SaveStudyMaterial";
        }
    }
}
