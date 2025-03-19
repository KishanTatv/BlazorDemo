using SMS.DataAccess.Models.Auth.Request;
using SMS.Shared.HttpManager.DTO;

namespace BlazorApp.Data.Interfaces.Auth
{
    public interface IAuth
    {
        Task<HttpResponseDTO<List<string>>> Login(UserLoginDTO model);

    }
}
