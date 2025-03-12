using static SMS.Shared.Static.Enum.HttpStatusCodes;

namespace SMS.Shared.HttpManager.DTO
{
    public class HttpResponseDTO<T>
    {
        public bool Result { get; set; }
        public HttpStatus StatusCode { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
