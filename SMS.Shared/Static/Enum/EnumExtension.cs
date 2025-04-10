using System.ComponentModel;
using System.Reflection;

public static class EnumExtensions
{
    public static string GetDescription(this Enum value)
    {
        FieldInfo fi = value.GetType().GetField(value.ToString());

        if (fi != null && Attribute.GetCustomAttribute(fi, typeof(DescriptionAttribute)) is DescriptionAttribute description)
        {
            return description.Description;
        }

        return value.ToString();
    }
}
