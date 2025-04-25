using SMS.DataAccess.Models.Auth.Request;
using SMS.DataAccess.Models.Auth.Response;
using SMS.Shared.HttpManager.DTO;

namespace BlazorApp.Data.Interfaces.Auth
{
    public interface IAuth
    {
        Task<HttpResponseDTO<List<string>>> Login(UserLoginDTO model);

        Task<HttpResponseDTO<string>> GetUserPhoto(UserPhoto model);

        Task<HttpResponseDTO<IEnumerable<Menu>>> GetMenu(int roleId);
    }
}
