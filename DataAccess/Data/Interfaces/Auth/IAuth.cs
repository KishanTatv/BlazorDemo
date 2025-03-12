using BlazorApp.Client.Models.Request.Auth;
using SMS.Shared.HttpManager.DTO;

namespace BlazorApp.Data.Interfaces.Auth
{
    public interface IAuth
    {
        Task<HttpResponseDTO<List<string>>> Login(UserLoginDTO model);

    }
}
