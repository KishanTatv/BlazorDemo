using System.Globalization;

namespace SMS.Shared.Static.Resources
{
    public static class MultiLangualService
    {
        public static string GetCurrentCulture()
        {
            return CultureInfo.CurrentCulture.Name;
        }

        public static void SetCulture(string culture)
        {
            var newCulture = new CultureInfo(culture);
            CultureInfo.DefaultThreadCurrentCulture = newCulture;
            CultureInfo.DefaultThreadCurrentUICulture = newCulture;
        }
    }
}
