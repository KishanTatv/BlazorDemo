using System.Globalization;
using System.Resources;

namespace SMS.Shared.Static.Resources
{
    public static class ResourcesManager
    {
        private static ResourceManager _resourceManager;

        static ResourcesManager()
        {
            _resourceManager = new ResourceManager("SMS.Shared.Static.Resources.AppResources", typeof(ResourcesManager).Assembly);
        }

        public static string GetString(this System.Enum enumVal)
        {
            return _resourceManager.GetString(enumVal.ToString(), CultureInfo.CurrentCulture) ?? EnumHelper.GetDescription(enumVal);
        }
    }
}
