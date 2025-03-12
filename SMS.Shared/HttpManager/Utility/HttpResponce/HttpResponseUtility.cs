using SMS.Shared.HttpManager.DTO;
using SMS.Shared.Static.Constants;
using static SMS.Shared.Static.Enum.HttpStatusCodes;

namespace SMS.Shared.HttpManager.Utility.HttpResponce
{
    public static class HttpResponseUtility
    {
        public static HttpResponseDTO<T> HttpConnectionErrorResponse<T>()
        {
            return new HttpResponseDTO<T>()
            {
                Message = HttpResponseMessages.msgHttpConnectionFailed,
                StatusCode = HttpStatus.InternalServerError,
                Result = false
            };
        }
        public static HttpResponseDTO<T> HttpRequestFailedErrorResponse<T>()
        {
            return new HttpResponseDTO<T>()
            {
                Message = HttpResponseMessages.msgHttpRequestFailed,
                StatusCode = HttpStatus.InternalServerError,
                Result = false
            };
        }
        public static HttpResponseDTO<string> NotFoundResponse()
        {
            return new HttpResponseDTO<string>
            {
                Message = HttpResponseMessages.msgHttpRequestFailed,
                StatusCode = HttpStatus.InternalServerError,
                Result = true
            };
        }
        public static HttpResponseDTO<string> BadRequestResponse()
        {
            return new HttpResponseDTO<string>
            {
                Message = HttpResponseMessages.msgHttpRequestFailed,
                StatusCode = HttpStatus.InternalServerError,
                Result = true
            };
        }

    }
}
