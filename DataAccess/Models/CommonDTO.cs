namespace SMS.DataAccess.Models
{
    public class SelectOptionDTO
    {
        public string Key { get; set; } = string.Empty;
        public int Id { get; set; }
        public string Value { get; set; } = string.Empty;
    }

    public class FilterViewModel
    {
        public int DisplayLength { get; set; } = 10;
        public int DisplayStart { get; set; } = 0;
        public string? SortCol { get; set; }
        public string? SortDir { get; set; }
    }

    public class KeyPairDTO<T>
    {
        public string Name { get; set; }
        public T Value { get; set; }
    }
}
