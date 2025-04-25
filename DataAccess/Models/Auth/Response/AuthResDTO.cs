namespace SMS.DataAccess.Models.Auth.Response
{
    public class Menu
    {
        public int MenuId { get; set; }
        public string Name { get; set; } = null!;
        public int? ParentMenuId { get; set; }
        public int MenuRole { get; set; }
        public int MenuOrder { get; set; }
        public string? MenuIcon { get; set; }
        public string? MenuRoute { get; set; }
        public List<Menu> InverseParentMenu { get; set; }
    }
}
