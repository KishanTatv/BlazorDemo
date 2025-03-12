using System.Text;
using System.Text.Json;

namespace SMS.Shared.HttpManager.Utility
{
    public static class TypeConversionUtility
    {
        public static StringContent ConvertToStringContent<T>(T data)
        {
            return new StringContent(JsonSerializer.Serialize(data), Encoding.UTF8, "application/json");
        }

        public static int ConvertStringToInt(string str, int defaultValue = -1)
        {
            if (!string.IsNullOrWhiteSpace(str) && !string.IsNullOrEmpty(str) && double.TryParse(str, out double doubleResult) && !double.IsNaN(doubleResult))
            {
                return (int)doubleResult;
            }

            return defaultValue;
        }
    }
}
