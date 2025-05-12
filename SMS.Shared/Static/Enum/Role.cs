using System.ComponentModel;

namespace SMS.Shared.Static.Enum
{
    public enum Roles
    {
        [Description("Super Admin")]
        SuperAdmin = 1,
        [Description("Admin")]
        Admin = 2,
        [Description("Teacher")]
        Teacher = 4,
        [Description("Student")]
        Student = 8,
        [Description("Parent")]
        Parent = 16,
        [Description("Librarian")]
        Librarian = 32,
        [Description("ShopKeeper")]
        ShopKeeper = 64,
        [Description("External Supervisor")]
        ExternalSupervisor = 128,
    }

}
