using System.ComponentModel;

namespace SMS.Shared.Static.Enum
{
    public class HttpStatusCodes
    {
        public enum HttpStatus
        {
            [Description("Internal server error")]
            InternalServerError = 500
        }

    }
}
