using Blazored.LocalStorage;
using SMS.Shared.Static.Enum;
using System.IdentityModel.Tokens.Jwt;

namespace SMS.Shared.JWTToken
{

    public class TokenService : ITokenService
    {
        private JwtDTO? _tokenData;

        public static readonly string TOKEN_KEY = "token";
        public static readonly string REFRESH_TOKEN_KEY = "refreshToken";
        private readonly ILocalStorageService _localStorage;

        public TokenService(ILocalStorageService localStorage)
        {
            _localStorage = localStorage;
        }

        public JwtDTO? TokenData => _tokenData;

        public async Task StoreTokensAsync(string accessToken, string refreshToken)
        {
            await _localStorage.SetItemAsync(TOKEN_KEY, accessToken);
            await _localStorage.SetItemAsync(REFRESH_TOKEN_KEY, refreshToken);
        }

        public async Task RemoveTokensAsync()
        {
            await _localStorage.RemoveItemAsync(TOKEN_KEY);
            await _localStorage.RemoveItemAsync(REFRESH_TOKEN_KEY);
            _tokenData = null;
        }

        public async Task<string> GetUserToken()
        {
            string? token = await _localStorage.GetItemAsync<string>(TOKEN_KEY);
            return await _localStorage.GetItemAsync<string>(TOKEN_KEY) ?? string.Empty;
        }

        public async Task<JwtDTO?> GetClaimFromToken()
        {

            if (_tokenData == null)
            {
                var token = await GetUserToken();
                var jwtHandler = new JwtSecurityTokenHandler();
                if (!string.IsNullOrWhiteSpace(token) && !string.IsNullOrEmpty(token) && jwtHandler.CanReadToken(token))
                {
                    var claim = jwtHandler.ReadJwtToken(token).Claims;
                    JwtDTO jwtData = new JwtDTO()
                    {
                        UserName = claim?.FirstOrDefault(c => c.Type == "unique_name").Value,
                        Role = int.Parse(claim?.FirstOrDefault(c => c.Type == "role").Value),
                        CurrentYearId = int.Parse(claim?.FirstOrDefault(c => c.Type == "CurrentYearId").Value),
                        UserId = int.Parse(claim?.FirstOrDefault(c => c.Type == "UserId").Value),
                        Email = claim?.FirstOrDefault(c => c.Type == "email").Value
                    };
                    switch ((Roles)jwtData.Role)
                    {
                        case Roles.Teacher:
                            jwtData.TeacherId = int.Parse(claim?.FirstOrDefault(c => c.Type == "TeacherId").Value);
                            jwtData.StaffId = int.Parse(claim?.FirstOrDefault(c => c.Type == "StaffId").Value);
                            break;
                        case Roles.Student:
                            jwtData.StudentId = int.Parse(claim?.FirstOrDefault(c => c.Type == "StudentId").Value);
                            break;
                        case Roles.Parent:
                            jwtData.ParentId = int.Parse(claim?.FirstOrDefault(c => c.Type == "ParentId").Value);
                            break;
                    }
                    _tokenData = jwtData;
                    return _tokenData;
                }
                return null;
            }
            return null;
        }

        public void SetTokenData(JwtDTO token)
        {
            _tokenData = token;
        }

        public async Task<bool> IsTokenValid()
        {
            var token = await GetUserToken();
            if (!string.IsNullOrEmpty(token))
            {
                if (new JwtSecurityTokenHandler().ReadJwtToken(token).ValidTo <= DateTime.UtcNow)
                {
                    return false;
                }
                return true;
            }
            return false;
        }
    }
}
